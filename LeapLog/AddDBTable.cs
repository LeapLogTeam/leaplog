using System;
using System.Collections.Generic;
using System.Text;

namespace LeapLog

{
    /// <summary>
    /// This class allows the user to create new tables into the DB
    /// </summary>
    class AddDBTable
    {

        //****************T Accounts *******************

        public static void TAccounts (string tableName)
        {
            LeapLogDBManager sqlTables = new LeapLogDBManager();

            string TaccountName = tableName + "Taccount";

            string dbString = @"CREATE TABLE  " + TaccountName + "( ID INT IDENTITY(1, 1) NOT NULL, Account  NVARCHAR(50) NULL, Type NVARCHAR(50) NULL," +
    "DebitList MONEY NULL, CreditList MONEY NULL, " +
    "TotalDebit MONEY NULL, TotalCredit  MONEY NULL, Balance MONEY NULL, PRIMARY KEY CLUSTERED(Id ASC))";
            sqlTables.WriteData(dbString);
        }


        //****************Balance sheet*******************
        public static void BalanceSheet(string tableName)
        {
            LeapLogDBManager sqlTables = new LeapLogDBManager();

            string BalanceSheetName = tableName + "BalanceSheet";

            string dbString = @"CREATE TABLE  " + BalanceSheetName + "( ID INT IDENTITY(1, 1) NOT NULL, Asset_Account_Name  NVARCHAR(50) NULL,  Asset_Account_Balance  MONEY NULL, Total_Assets MONEY NULL," +
    "Liability_Account_Name NVARCHAR(50) NULL, Liability_Account_Balance MONEY NULL, " +
    "Total_Liability MONEY NULL,PRIMARY KEY CLUSTERED(Id ASC))";
            sqlTables.WriteData(dbString);
        }


        //****************Income Statement*******************
        public static void IncomeStatement(string tableName)
        {
            LeapLogDBManager sqlTables = new LeapLogDBManager();
            string IncomeStatementName = tableName + "IncomeStatement";


            string dbString = @"CREATE TABLE  " + IncomeStatementName + "( ID INT IDENTITY(1, 1) NOT NULL,Total_Revenue MONEY NULL, Total_Expense MONEY NULL," +
    "Net_Income MONEY NULL,PRIMARY KEY CLUSTERED(Id ASC))";
            sqlTables.WriteData(dbString);
        }


        //****************Statement of Owner Equity*******************
        public static void StatementOfOwnerEquity(string tableName)
        {
            LeapLogDBManager sqlTables = new LeapLogDBManager();
            string StatementOfOEName = tableName + "StatementOfOE";


            string dbString = @"CREATE TABLE  " + StatementOfOEName + "( ID INT IDENTITY(1, 1) NOT NULL,Start_Capital MONEY NULL, Net_Income MONEY NULL, Total_Withdrawals MONEY NULL," +
    "Final_Capital MONEY NULL,PRIMARY KEY CLUSTERED(Id ASC))";
            sqlTables.WriteData(dbString);
        }

         



    }

}
