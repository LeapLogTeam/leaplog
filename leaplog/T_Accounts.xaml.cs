using System;
using System.Collections.Generic;
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
     /// Go ahead and write a summary for T_Accounts.xaml here!
     /// </summary>
     public partial class T_Accounts : UserControl
     {
          public T_Accounts()
          {
               InitializeComponent();
          }

        //method that refreshes the t-account grid so that it is updated with current journal entries
        public void Refresh()
        {
            //clear grid
            a_Grid.Items.Clear();
            l_Grid.Items.Clear();
            oe_Grid.Items.Clear();

            //add t-accounts to respective grids
            for (int i = 0; i < Database.TEntries.Count; i++)
            {
                if (Database.TEntries[i].Type == "Asset")
                {
                    a_Grid.Items.Add(Database.TEntries[i]);
                }
                else if (Database.TEntries[i].Type == "Liability")
                {
                    l_Grid.Items.Add(Database.TEntries[i]);
                }
                else if (Database.TEntries[i].Type == "Owner's Equity")
                {
                    oe_Grid.Items.Add(Database.TEntries[i]);
                }
            }
        }

        //method that processes temporary t-accounts by either
        //adding them to the t-account list or updating t-account list
        //with the temporary t-account data
        public static void add_taccs(List<Entry_tacc> tempAccounts)
        {
            //process each temporary account
            Entry_tacc acc1 = new Entry_tacc();
            acc1 = tempAccounts[0];
            Entry_tacc acc2 = new Entry_tacc();
            acc2 = tempAccounts[1];

            //if database is empty of t-accounts
            if (Database.TEntries.Count == 0)
            {
                Database.TEntries.Add(acc1);
                Database.TEntries.Add(acc2);
            }

            //if database is not empty,
            //compare and either update or add the accounts
            //to the database
        }

        //method that creates two temporary t-accounts that corresponds to a journal entry
        public static List<Entry_tacc> get_taccs(Entry entry)
        {
            //create a new list of t-account entries
            List<Entry_tacc> tempAccounts = new List<Entry_tacc>();

            //create two t-accounts and populate with data from journal entry

            //account 1
            Entry_tacc acc1 = new Entry_tacc();
            acc1.Date = entry.Date;
            acc1.Account = entry.Account1.Trim();
            acc1.Type = entry.Type1;
            acc1.Debit.Add(entry.Debit);
            acc1.Credit.Add(0);

            //calculate balance
            if (acc1.Type == "Asset")
            {
                acc1.Balance = acc1.Debit[0] - acc1.Credit[0];
            }
            else
            {
                acc1.Balance = acc1.Credit[0] - acc1.Debit[0];
            }

            //account 2
            Entry_tacc acc2 = new Entry_tacc();
            acc2.Date = entry.Date;
            acc2.Account = entry.Account2.Trim();
            acc2.Type = entry.Type2;
            acc2.Debit.Add(0);
            acc2.Credit.Add(entry.Credit);

            //calculate balance
            if (acc2.Type == "Asset")
            {
                acc2.Balance = acc1.Debit[0] - acc2.Credit[0];
            }
            else
            {
                acc2.Balance = acc1.Credit[0] - acc2.Debit[0];
            }

            //add t-accounts to list
            tempAccounts.Add(acc1);
            tempAccounts.Add(acc2);

            //return the t-accounts
            return tempAccounts;
          }

        //method that occurs when a cell in any of the grids is clicked
        private void DataGridCell_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //open a new window for the account
            SingleAccount accountWindow = new SingleAccount();
            accountWindow.Show();
        }
    }
}
