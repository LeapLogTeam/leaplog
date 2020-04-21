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
    /// Interaction logic for IncomeStatement.xaml
    /// </summary>
    public partial class IncomeStatement : UserControl
    {
        public IncomeStatement()
        {
            InitializeComponent();
            DateTime now = DateTime.Now;
            string format = "MMMM dd, yyyy";
            Database.from_date = now;
            Database.to_date = now;
            From.Text = now.ToString(format);
            To.Text = now.ToString(format);
        }

        // method that refreshes the income-statement grid so that it is updated with current entries
        public void Refresh()
        {
            // Clear all grids and textbox
            entryGridE.Items.Clear();
            entryGridR.Items.Clear();
            entryGridTE.Items.Clear();
            entryGridTR.Items.Clear();
            textBox1.Clear();

            int Total_revenue = 0;
            int Total_expenses = 0;

            //add t-accounts to respective grids
            DateTime from = Database.from_date;
            DateTime to = Database.to_date;
            for (int i = 0; i < Database.TEntries.Count; i++)
            {
                Entry_tacc _tacc = Database.TEntries[i];
                DateTime td = _tacc.Date;
                if (td.Day >= from.Day && td.Month >= from.Month && td.Year >= from.Year &&
                    td.Day <= to.Day && td.Month <= to.Month && td.Year <= to.Year)
                {
                    string type = _tacc.Type;
                    Entry_tacc t = _tacc.Clone();
                    t.Balance = Math.Abs(_tacc.Balance);
                    switch (type)
                    {
                        case "Revenue":
                            entryGridR.Items.Add(t);
                            Total_revenue += t.Balance;
                            break;
                        case "Expense":
                            entryGridE.Items.Add(t);
                            Total_expenses += t.Balance;
                            break;
                    }
                }
            }

            // Add the totals
            entryGridTR.Items.Add(new Total() { total = Total_revenue });
            entryGridTE.Items.Add(new Total() { total = Total_expenses });
            textBox1.Text = (Total_revenue - Total_expenses).ToString();
        }

        private void from_SelectionChanged(object sender, RoutedEventArgs e)
        {
            DateTime.TryParse(From.Text, out Database.from_date);
            Refresh();
        }

        private void to_SelectionChanged(object sender, RoutedEventArgs e)
        {
            DateTime.TryParse(To.Text, out Database.to_date);
            Refresh();
        }

        //method for when help feature button is clicked
        private void incomeHelpButton_Click(object sender, RoutedEventArgs e)
        {
            incomeHelpWindow.Visibility = Visibility.Visible;
        }

        //method for when help feature close button is clicked
        private void incomeStatementCloseButton_Click(object sender, RoutedEventArgs e)
        {
            incomeHelpWindow.Visibility = Visibility.Collapsed;
        }
    }
}
