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

                //add entry into Database
                Database.Entries.Add(tempEntry);
                //separate entry into two t-accounts
                List<Entry_tacc> tempAccounts = T_Accounts.get_taccs(tempEntry);
                //process t-accounts
                T_Accounts.add_taccs(tempAccounts);
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
    }
}
