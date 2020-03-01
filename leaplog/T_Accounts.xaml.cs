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
            entryGrid.Items.Clear();

            for (int i = 0; i < Database.TEntries.Count; i++)
            {
                entryGrid.Items.Add(Database.TEntries[i]);
            }
        }

        //method that processes temporary t-accounts by either
        //adding them to the t-account list or updating t-account list
        //with the temporary t-account data
        public static void add_taccs(List<Entry_tacc> tempAccounts)
        {
            //process first t-account
            Entry_tacc acc1 = new Entry_tacc();
            acc1 = tempAccounts[0];

            //process second t-account
            Entry_tacc acc2 = new Entry_tacc();
            acc2 = tempAccounts[1];

            //if list of t-accounts is empty
            if (Database.TEntries.Count == 0)
            {
                //update necessary properties
                acc1.Credit = 0;
                if (acc1.Type == "Asset")
                {
                    //update the account's balance by subtracting the credit from the debit
                    acc1.Balance = acc1.Debit - acc1.Credit;
                }
                //if it is a liability or owner's equity type
                else
                {
                    //update the account's balance by subtracting the debit from the credit
                    acc1.Balance = acc1.Credit - acc1.Debit;
                }

                //update necessary properties
                acc2.Debit = 0;
                if (acc2.Type == "Asset")
                {
                    //update the account's balance by subtracting the credit from the debit
                    acc2.Balance = acc2.Debit - acc2.Credit;
                }
                //if it is a liability or owner's equity type
                else
                {
                    //update the account's balance by subtracting the debit from the credit
                    acc2.Balance = acc2.Credit - acc2.Debit;
                }

                //add t-account to list
                Database.TEntries.Add(acc1);
                Database.TEntries.Add(acc2);
            }
            else
            {
                //search through list of t-accounts
                for (int i = 0; i < Database.TEntries.Count; i++)
                {
                    //if t-account exists already
                    if (acc1.Account == Database.TEntries[i].Account)
                    {
                        //add the temporary t-account debit to the original debit
                        Database.TEntries[i].Debit += acc1.Debit;
                        //if it is an asset type
                        if (Database.TEntries[i].Type == "Asset")
                        {
                            //update the original account's balance by subtracting the credit from the debit
                            Database.TEntries[i].Balance = Database.TEntries[i].Debit - Database.TEntries[i].Credit;
                        }
                        //if it is a liability or owner's equity type
                        else
                        {
                            //update the original account's balance by subtracting the debit from the credit
                            Database.TEntries[i].Balance = Database.TEntries[i].Credit - Database.TEntries[i].Debit;
                        }
                    }
                    //if end of list reached and the t-account does not exist,
                    //update the account's properties and add account to list
                    else if (i == Database.TEntries.Count - 1 && !(acc1.Account == Database.TEntries[i].Account))
                    {
                        //update necessary properties
                        acc1.Credit = 0;
                        if (acc1.Type == "Asset")
                        {
                            //update the account's balance by subtracting the credit from the debit
                            acc1.Balance = acc1.Debit - acc1.Credit;
                        }
                        //if it is a liability or owner's equity type
                        else
                        {
                            //update the account's balance by subtracting the debit from the credit
                            acc1.Balance = acc1.Credit - acc1.Debit;
                        }

                        //add t-account to list
                        Database.TEntries.Add(acc1);
                    }

                    //if t-account exists already
                    if (acc2.Account == Database.TEntries[i].Account)
                    {
                        //add the temporary t-account credit to the original credit
                        Database.TEntries[i].Credit += acc2.Credit;
                        //if it is an asset type
                        if (Database.TEntries[i].Type == "Asset")
                        {
                            //update the original account's balance by subtracting the credit from the debit
                            Database.TEntries[i].Balance = Database.TEntries[i].Debit - Database.TEntries[i].Credit;
                        }
                        //if it is a liability or owner's equity type
                        else
                        {
                            //update the original account's balance by subtracting the debit from the credit
                            Database.TEntries[i].Balance = Database.TEntries[i].Credit - Database.TEntries[i].Debit;
                        }
                    }
                    //else, if end of list reached and the t-account does not exist,
                    //update the account's properties and add account to list
                    else if (i == Database.TEntries.Count - 1 && !(acc2.Account == Database.TEntries[i].Account))
                    {
                        //update necessary properties
                        acc2.Debit = 0;
                        if (acc2.Type == "Asset")
                        {
                            //update the account's balance by subtracting the credit from the debit
                            acc2.Balance = acc2.Debit - acc2.Credit;
                        }
                        //if it is a liability or owner's equity type
                        else
                        {
                            //update the account's balance by subtracting the debit from the credit
                            acc2.Balance = acc2.Credit - acc2.Debit;
                        }

                        //add t-account to list
                        Database.TEntries.Add(acc2);
                    }
                }
            }

        }

        //method that creates two temporary t-accounts that corresponds to a journal entry
        public static List<Entry_tacc> get_taccs(Entry entry)
        {
            //create a new list of t-account entries
            List<Entry_tacc> tempAccounts = new List<Entry_tacc>();

            //create two t-accounts and populate with data from journal entry
            Entry_tacc acc1 = new Entry_tacc();
            acc1.Date = entry.Date;
            acc1.Account = entry.Account1;
            acc1.Type = entry.Type1;
            acc1.Debit = entry.Debit;

            Entry_tacc acc2 = new Entry_tacc();
            acc2.Date = entry.Date;
            acc2.Account = entry.Account2.Trim();
            acc2.Type = entry.Type2;
            acc2.Credit = entry.Credit;

            //add t-accounts to list
            tempAccounts.Add(acc1);
            tempAccounts.Add(acc2);

            //return the t-accounts
            return tempAccounts;
          }
     }
}
