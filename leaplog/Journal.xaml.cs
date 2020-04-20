using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LeapLog
{
    /// <summary>
    /// The Journal class allows the user to create new journal entries that can be stored
    /// using the Database class.
    /// </summary>
    public partial class Journal : UserControl
    {

        
       
        
        
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
                tempEntry.Account1 = account1TB.Text;
                tempEntry.Account2 = "      " + account2TB.Text;
                tempEntry.Debit = Int32.Parse(debitTB.Text);
                tempEntry.Credit = Int32.Parse(creditTB.Text);
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
 
                sqlTables.WriteData("INSERT INTO " + tableName + " VALUES ('" + DateTime.Now + "','" + account1TB.Text + "','" + account2TB.Text + "','" + type1CB.Text + "','" + type2CB.Text + "','" + Int32.Parse(debitTB.Text) + "','" + Int32.Parse(creditTB.Text) + "')");



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
            //<<--------this creates the datatable into the database------->>
            string messageBoxText = "Journal field cannot be null or empty";
            string caption = "Wrong Input";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Warning;


            LeapLogDBManager sqlTables = new LeapLogDBManager();
            string tableName = user_Input.Text.Replace(" ", "");

            string dbString = @"CREATE TABLE  " + tableName + "( ID INT IDENTITY(1, 1) NOT NULL,Date DATE NULL, Account_1  NVARCHAR(50) NULL, Account_2 NVARCHAR(50) NULL," +
"Type_1 NVARCHAR(50) NULL, Type_2 NVARCHAR(50) NULL, " +
"Debit MONEY NULL, Credit  MONEY NULL,PRIMARY KEY CLUSTERED(Id ASC))";
            if (String.IsNullOrEmpty(user_Input.Text) || user_Input.Text == "")
            {
                MessageBox.Show(messageBoxText, caption, button, icon);
            }
             

            else
                sqlTables.WriteData(dbString);
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
        }
    }
}
