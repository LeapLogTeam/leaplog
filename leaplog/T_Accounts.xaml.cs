﻿using System;
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

          public void Refresh()
          {
               List<Entry_tacc> accounts = new List<Entry_tacc>();
               entryGrid.Items.Clear();
               int balance = 0;
               for (int i = 0; i < Database.Entries.Count; i++)
               {
                    Entry entry = Database.Entries[i];
                    Entry_tacc tacc1 = Get_tacc(entry, 0, balance);
                    balance = tacc1.Balance;
                    Entry_tacc tacc2 = Get_tacc(entry, 1, balance);
                    balance = tacc1.Balance;

                    entryGrid.Items.Add(tacc1);
                    entryGrid.Items.Add(tacc2);
               }
          }

          public Entry_tacc Get_tacc(Entry Entry, int Account_number, int balance)
          {
               Entry_tacc acc = new Entry_tacc();
               acc.Date = Entry.Date;
               
               if (Account_number == 0)
               {
                    acc.Description = Entry.Account1;
                    acc.Account_Type = account_type.Debit;
                    int Debit = Entry.Debit;
                    acc.Debit = Debit;
                    acc.Credit = 0;
                    acc.Balance = balance + Debit;
               }
               else
               {
                    acc.Description = Entry.Account2;
                    acc.Account_Type = account_type.Credit;
                    int Credit = Entry.Credit;
                    acc.Debit = 0;
                    acc.Credit = Credit;
                    acc.Balance = balance - Credit;
               }

               return acc;
          }
     }
}
