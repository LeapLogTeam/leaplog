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
    /// Go ahead and write a summary for Journal.xaml right here! Sometime...
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
            Entry tempEntry = new Entry();

            //clear any warnings, if necessary
            warningTB.Visibility = Visibility.Hidden;

            //populates new entry object with user data given
            try
            {
                tempEntry.Account1 = account1TB.Text;
                tempEntry.Account2 = "      " + account2TB.Text;
                tempEntry.Debit = Int32.Parse(debitTB.Text);
                tempEntry.Credit = Int32.Parse(creditTB.Text);
                tempEntry.Category1 = category1CB.Text;
                tempEntry.Category2 = category2CB.Text;

                //add entry into entryGrid
                entryGrid.Items.Add(tempEntry);

                //add entry into entry Database
                Database.Entries.Add(tempEntry);
            }
            catch {
                warningTB.Visibility = Visibility.Visible;
            }

            //clear textboxes
            account1TB.Text = "";
            account2TB.Text = "";
            debitTB.Text = "";
            creditTB.Text = "";
            category1CB.SelectedItem = null;
            category2CB.SelectedItem = null;
        }
    }
}
