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
            Database.selected_dates = new SelectedDatesCollection(calendar);
            Database.selected_dates.Add(DateTime.Now);
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
            for (int i = 0; i < Database.TEntries.Count; i++)
            {
                Entry_tacc _tacc = Database.TEntries[i];
                DateTime td = _tacc.Date;
                for (int l = 0; l < Database.selected_dates.Count; l++)
                {
                    DateTime date = Database.selected_dates[l];
                    if (td.Day == date.Day && td.Month == date.Month && td.Year == date.Year)
                    {
                        string type = _tacc.Type;
                        switch (type)
                        {
                            case "Asset":
                                entryGridR.Items.Add(_tacc);
                                Total_revenue += _tacc.Balance;
                                break;
                            case "Liability":
                                entryGridE.Items.Add(_tacc);
                                Total_expenses += _tacc.Balance;
                                break;
                        }
                    }
                }
            }

            // Add the totals
            entryGridTR.Items.Add(new Total() { total = Total_revenue });
            entryGridTE.Items.Add(new Total() { total = Total_expenses });
            textBox1.Text = (Total_revenue - Total_expenses).ToString();
        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            // Update the calendar date and than refresh
            Calendar calendar = sender as Calendar;
            if (calendar.SelectedDates.Count > 0)
            {
                Database.selected_dates = calendar.SelectedDates;
                Refresh();
            }
        }
    }
}
