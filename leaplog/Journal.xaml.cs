using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using Excel = Microsoft.Office.Interop.Excel;
 



namespace LeapLog
{
    /// <summary>
    /// The Journal class allows the user to create new journal entries that can be stored
    /// using the Database class.
    /// </summary>
    public partial class Journal : UserControl
    {
        public static string passingText;




        public Journal()
        {
            InitializeComponent();
        }
        
        //Add new entry button
        private void addEntryBtn_Click(object sender, RoutedEventArgs e)
        {
            //new entry is created
            Entry tempEntry = new Entry();

            //clear any warnings, if necessary
            warningTB.Visibility = Visibility.Hidden;

            //populates new entry object with user data given
            //REVISION NEEDED: validation could be improved.
            try
            {
                //process account names to make sure no quotation marks are entered
                if (account1TB.Text.Contains("'") || account2TB.Text.Contains("'"))
                {
                    throw new Exception();
                }

                tempEntry.Account1 = account1TB.Text;
                tempEntry.Account2 = "      " + account2TB.Text;
                tempEntry.Debit = Double.Parse(debitTB.Text);
                tempEntry.Credit = Double.Parse(creditTB.Text);
                tempEntry.Type1 = type1CB.Text;
                tempEntry.Type2 = type2CB.Text;

                //add entry into entryGrid
                entryGrid.Items.Add(tempEntry);

                //separate entry into two t-accounts
                List<Entry_tacc> tempAccounts = T_Accounts.get_taccs(tempEntry);
                //process t-accounts
                T_Accounts.add_taccs(tempAccounts);

                //<<-------------inserting data to the database-------------------->>
                LeapLogDBManager sqlTables = new LeapLogDBManager();
                 
                //<<------- this chooses the table where the data will be added to-------->>
                 string tableName = user_Input.Text.Replace(" ", "");
 
                sqlTables.WriteData("INSERT INTO " + tableName + " VALUES ('" + DateTime.Now + "','" + account1TB.Text + "','" + account2TB.Text + "','" + type1CB.Text + "','" + type2CB.Text + "','" + double.Parse(debitTB.Text) + "','" + double.Parse(creditTB.Text) + "')");

            }
            catch {
                //if incorrect data entered, warning given
                //and entry not saved
                warningTB.Visibility = Visibility.Visible;
            }

            //clear textboxes
            account1TB.Text = "";
            account2TB.Text = "";
            debitTB.Text = "";
            creditTB.Text = "";
            type1CB.SelectedItem = null;
            type2CB.SelectedItem = null;

           

        }

        private void enter_button_Click(object sender, RoutedEventArgs e)
        {

            string messageBoxText = "Journal field cannot be null or empty";
            string caption = "Wrong Input";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Warning;
            //**********************Check if table name already exists**********************

            List<String> list = new List<String>(); // to save the table names

            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            int counterV = 0;
            string sql = null;

            connetionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Environment.CurrentDirectory}\Database1.MDF;Integrated Security=True";
            sql = "Select DISTINCT(name) FROM sys.Tables";

            connection = new SqlConnection(connetionString);

            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close();

                for (counterV = 0; counterV <= ds.Tables[0].Rows.Count - 1; counterV++)
                {
                    list.Add(ds.Tables[0].Rows[counterV].ItemArray[0].ToString());
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Can not open connection ! ");
            }
            //******************end of block of code*********************************


            //******************Control if statement******************

            if (list.FindIndex(x => x.Equals(user_Input.Text.Trim(), StringComparison.CurrentCultureIgnoreCase)) != -1)

                MessageBox.Show("Table name already taken.", "Try again", button, icon);

            else
            {
                string tableName = user_Input.Text.Replace(" ", "");
                // If the tableName is empty quit this function.
                if (tableName.Length < 1)
                {
                    MessageBox.Show("No name was given to the table.", "Try again", button, icon);
                    return;
                }
                // Fail safe for if the user inputs an number as the first word.
                Match match = Regex.Match(tableName[0].ToString(), "[0-9]");
                if (match.Success)
                {
                    MessageBox.Show("Letters only as the first character.", "Try again", button, icon);
                    return;
                }
                //<<--------this creates the datatable into the database------->>
                LeapLogDBManager sqlTables = new LeapLogDBManager();
                string journalName = tableName + "Journal";
                string dbString = @"CREATE TABLE  " + journalName + "( ID INT IDENTITY(1, 1) NOT NULL,Date DATE NULL, Account_1  NVARCHAR(50) NULL, Account_2 NVARCHAR(50) NULL," +
    "Type_1 NVARCHAR(50) NULL, Type_2 NVARCHAR(50) NULL, " +
    "Debit MONEY NULL, Credit  MONEY NULL,PRIMARY KEY CLUSTERED(Id ASC))";
                if (String.IsNullOrEmpty(user_Input.Text) || user_Input.Text == "")
                {
                    MessageBox.Show(messageBoxText, caption, button, icon);
                }


                else
                {
                    sqlTables.WriteData(dbString);
                    MessageBox.Show("Tables " + user_Input.Text + " added to Database. ", "Table added", button, icon);

                    AddDBTable.TAccounts(tableName);
                    AddDBTable.BalanceSheet(tableName);
                    AddDBTable.IncomeStatement(tableName);
                    AddDBTable.StatementOfOwnerEquity(tableName);
                  


                }
            }
        }

        //button that opens up journal help feature
        private void journalHelpButton_Click(object sender, RoutedEventArgs e)
        {
            journalHelpWindow1.Visibility = Visibility.Visible;
        }

        //button that changes to second help feature page
        private void forwardButton_Click(object sender, RoutedEventArgs e)
        {
            journalHelpWindow2.Visibility = Visibility.Visible;
        }

        //button that changes to first help feature page
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            journalHelpWindow2.Visibility = Visibility.Collapsed;
        }

        //button that closes help feature
        private void jCloseButton_Click(object sender, RoutedEventArgs e)
        {
            journalHelpWindow1.Visibility = Visibility.Collapsed;
            journalHelpWindow2.Visibility = Visibility.Collapsed;
            journalHelpWindow3.Visibility = Visibility.Collapsed;
        }

        //button that changes to third help window
        private void forwardButton2_Click(object sender, RoutedEventArgs e)
        {
            journalHelpWindow3.Visibility = Visibility.Visible;
        }

        //button that changes from third to second help window
        private void backButton2_Click(object sender, RoutedEventArgs e)
        {
            journalHelpWindow3.Visibility = Visibility.Collapsed;
        }

        private void toExcel_Click(object sender, RoutedEventArgs e)
        {
            //**************************flow control************************************
            string messageBoxText = "Journal field cannot be null or empty";
            string caption = "Wrong Input";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Warning;

            string tableName = user_Input.Text.Replace(" ", "");

            List<tableAdapterr> tablelist = new List<tableAdapterr>();

            //***********************from db to table adapter*******************************        

            if (String.IsNullOrEmpty(user_Input.Text) || user_Input.Text == "")
            {
                MessageBox.Show(messageBoxText, caption, button, icon);
            }
            else
            {
                SqlConnection conn = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Environment.CurrentDirectory}\Database1.MDF;Integrated Security=True");
                string query = "Select * from " + tableName + " ";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                sda.Fill(dataTable);
                //string name;


                //*********************if need assistance please ask ***************************
                //*****************************James Alexander **************************
                foreach (DataRow row in dataTable.Rows)
                {
                    tableAdapterr journalTable = new tableAdapterr();

                    /*name = row["username"].ToString().Trim();
                   System.Diagnostics.Debug.WriteLine(name);
                   list.Add(name);*/
                    journalTable.ID = Convert.ToInt32(row["ID"]);
                    journalTable.Date = row["Date"].ToString().Trim();
                    journalTable.Account_1 = row["Account_1"].ToString().Trim();
                    journalTable.Account_2 = row["Account_2"].ToString().Trim();
                    journalTable.Type_1 = row["Type_1"].ToString().Trim();
                    journalTable.Type_2 = row["Type_2"].ToString().Trim();
                    journalTable.Debit = Convert.ToDouble(row["Debit"]);
                    journalTable.Credit = Convert.ToDouble(row["Credit"]);


                    tablelist.Add(journalTable);



                }
                foreach (var i in tablelist)
                {
                    System.Diagnostics.Debug.WriteLine(i.Account_1);
                }

                //*************************************to excel****************************************

                //*********************if need assistance please ask ***************************
                //*****************************James Alexander **************************

                // Load up Excel, then make a new empty workbook.
                Excel.Application excelApp = new Excel.Application();



                object missing = System.Reflection.Missing.Value;

                Excel.Workbook oWB = excelApp.Workbooks.Add(missing);

                //excelApp.Workbooks.Add();
                // This example uses a single workSheet.
                Worksheet workSheet = (Worksheet)oWB.ActiveSheet;
                workSheet.Name = "Journal";
                // Establish column headings in cells.
                workSheet.Cells[1, "A"] = "ID";
                workSheet.Cells[1, "B"] = "Date";
                workSheet.Cells[1, "C"] = "Account 1";
                workSheet.Cells[1, "D"] = "Type 1";
                workSheet.Cells[1, "E"] = "Debit";
                workSheet.Cells[1, "F"] = "Account 2";
                workSheet.Cells[1, "G"] = "Type 2";
                workSheet.Cells[1, "H"] = "Credit";

                // Now, map all data in List<tableAdapterr> to the cells of the spreadsheet.
               //****************T Accounts *******************
                Worksheet workSheet2 = (Worksheet)oWB.Sheets.Add(missing, missing, 1, missing);
                workSheet2.Name = "T Accounts";
                // Establish column headings in cells.
                workSheet2.Cells[1, "A"] = "ID";             
                workSheet2.Cells[1, "B"] = "Account";
                workSheet2.Cells[1, "C"] = "Type";
                workSheet2.Cells[1, "D"] = "List of Debits";
                workSheet2.Cells[1, "E"] = "List of Credits";
                workSheet2.Cells[1, "F"] = "Total Debit";
                workSheet2.Cells[1, "G"] = "Total Credit";
                workSheet2.Cells[1, "H"] = "Balance";

                //****************Balance sheet*******************
                Worksheet workSheet3 = (Worksheet)oWB.Sheets.Add(missing, missing, 1, missing);
                workSheet3.Name = "Balance Sheet";
                // Establish column headings in cells.
                workSheet3.Cells[1, "A"] = "ID";
                workSheet3.Cells[1, "B"] = "Asset Account Name";
                workSheet3.Cells[1, "C"] = "Asset Account Balance";
                workSheet3.Cells[1, "D"] = "Total Assets";
                workSheet3.Cells[1, "E"] = "Liability or Owners Equity Account Name";
                workSheet3.Cells[1, "F"] = "Liability or Owners Equity Account Balance";
                workSheet3.Cells[1, "G"] = "Total Liabilities and Owners Equity";

                //****************Income Statement*******************
                Worksheet workSheet4 = (Worksheet)oWB.Sheets.Add(missing, missing, 1, missing);
                workSheet4.Name = "Income Statement";
                // Establish column headings in cells.
                workSheet4.Cells[1, "A"] = "ID";
                workSheet4.Cells[1, "B"] = "Total Revenue";         
                workSheet4.Cells[1, "C"] = "Total Expense";
                workSheet4.Cells[1, "D"] = "Net Income";

                //****************Statement of Owner Equity*******************
                Worksheet workSheet5 = (Worksheet)oWB.Sheets.Add(missing, missing, 1, missing);
                workSheet5.Name = "Statement of Owner Equity";
                // Establish column headings in cells.
                workSheet5.Cells[1, "A"] = "ID";
                workSheet5.Cells[1, "B"] = "Start Capital";       
                workSheet5.Cells[1, "C"] = "Net Income";
                workSheet5.Cells[1, "D"] = "Total Withdrawals";
                workSheet5.Cells[1, "E"] = "Final Capital";




                // Now, map all data in List<tableAdapterr> to the cells of the spreadsheet (journal).
                int row1 = 1;
                char letter = 'A';
                foreach (var i in tablelist)
                {
                    row1++;
                    letter++;

                    workSheet.Cells[row1, "A"] = i.ID;
                    workSheet.Cells[row1, "B"] = i.Date;
                    workSheet.Cells[row1, "C"] = i.Account_1;
                    workSheet.Cells[row1, "D"] = i.Type_1;
                    workSheet.Cells[row1, "E"] = i.Debit;        
                    workSheet.Cells[row1, "F"] = i.Account_2;
                    workSheet.Cells[row1, "G"] = i.Type_2;
                    workSheet.Cells[row1, "H"] = i.Credit;
                }


                // Now, map all data in List<tableAdapterr> to the cells of the Sheet 2 (t-accounts).

                int taccRow = 1;

                //for every account, pull data
                foreach (var i in Database.TEntries)
                {
                    taccRow++;

                    workSheet2.Cells[taccRow, "B"] = i.Account;    
                    workSheet2.Cells[taccRow, "C"] = i.Type;
                    workSheet2.Cells[taccRow, "D"] = string.Join("\n", i.Debit.ToArray());
                    workSheet2.Cells[taccRow, "E"] = string.Join("\n", i.Credit.ToArray());
                    workSheet2.Cells[taccRow, "F"] = i.TotalDebit;
                    workSheet2.Cells[taccRow, "G"] = i.TotalCredit;
                    workSheet2.Cells[taccRow, "H"] = i.Balance;
                    
                }

                // Now, map all data in List<tableAdapterr> to the cells of the Sheet 3 (balance sheet).

                int assetRow = 1;
                int loeRow = 1;

                //iterate through list of all asset accounts
                foreach (var i in Database.BalanceData.assetsList)
                {
                    assetRow++;

                    //get the account name and add to excel sheet
                    workSheet3.Cells[assetRow, "B"] = i.Account;
                    //get the account balance and add to excel sheet
                    workSheet3.Cells[assetRow, "C"] = i.Balance;
                }

                workSheet3.Cells[2, "D"] = Database.BalanceData.total_assets;

                //iterate through list of all other accounts
                foreach (var i in Database.BalanceData.loeList)
                {
                    loeRow++;

                    //get the account name and add to excel sheet
                    workSheet3.Cells[loeRow, "E"] = i.Account;
                    //get the account balance and add to excel sheet
                    workSheet3.Cells[loeRow, "F"] = i.Balance;

                } 
                workSheet3.Cells[2, "G"] = Database.BalanceData.total_loe;

                // Now, map all data in List<tableAdapterr> to the cells of the Sheet 4 (income statement).

                workSheet4.Cells[2, "B"] = Database.IncomeData.total_revenue;
                workSheet4.Cells[2, "C"] = Database.IncomeData.total_expenses;
                workSheet4.Cells[2, "D"] = Database.IncomeData.net_income;

                // Now, map all data in List<tableAdapterr> to the cells of the Sheet 5 (oe statement).

                workSheet5.Cells[2, "B"] = Database.SoeData.start_capital;
                workSheet5.Cells[2, "C"] = Database.SoeData.net_income;
                workSheet5.Cells[2, "D"] = Database.SoeData.total_withdrawals;
                workSheet5.Cells[2, "E"] = Database.SoeData.final_capital;

                // Give our table data a nice look and feel.
                workSheet.Range["A1"].AutoFormat(XlRangeAutoFormat.xlRangeAutoFormatClassic2);
                workSheet2.Range["A1"].AutoFormat(XlRangeAutoFormat.xlRangeAutoFormatClassic2);
                workSheet3.Range["A1"].AutoFormat(XlRangeAutoFormat.xlRangeAutoFormatClassic2);
                workSheet4.Range["A1"].AutoFormat(XlRangeAutoFormat.xlRangeAutoFormatClassic2);
                workSheet5.Range["A1"].AutoFormat(XlRangeAutoFormat.xlRangeAutoFormatClassic2);
                // Save the file, quit Excel, and display message to user.
                // workSheet.SaveAs($@"{Environment.CurrentDirectory}\" + tableName + ".xlsx");
                try
                {
                    oWB.SaveAs($@"{Environment.CurrentDirectory}\" + tableName + ".xlsx");
                }
                catch (Exception unused)
                {
                    excelApp.Quit();
                    return;
                }
                //excelApp.Quit();
                excelApp.Visible = true;

                System.Diagnostics.Debug.WriteLine("The tableOne.xslx file has been saved to your app folder");

                //*********************if need assistance please ask ***************************
                //*****************************James Alexander **************************
            }

        }

        private void account1TB_GotFocus(object sender, RoutedEventArgs e)
        {
            //clear any warnings, if necessary
            warningTB.Visibility = Visibility.Hidden;
        }
        private void user_Input_TextChanged(object sender, TextChangedEventArgs e)
        {
            passingText = user_Input.Text.Replace(" ", "");
        }
    }
}
