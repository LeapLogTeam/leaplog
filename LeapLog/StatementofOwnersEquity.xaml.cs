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
    /// Interaction logic for StatementofOwnersEquity.xaml
    /// </summary>
    public partial class StatementofOwnersEquity : UserControl
    {
        public bool can_Refresh = false;
        public StatementofOwnersEquity()
        {
            InitializeComponent();
            DateTime now = DateTime.Now;
            string format = "MMMM dd, yyyy";
            Database.sooe_date.from_date = now;
            Database.sooe_date.to_date = now;
            From.Text = now.ToString(format);
            To.Text = now.ToString(format);
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            can_Refresh = true;
        }

        public void Refresh()
        {
            // I don't know what is wrong but I need to do this else textboxes 1-4 will be null.
            if (!can_Refresh)
            {
                return;
            }

            textbox1.Clear();
            textbox2.Clear();
            textbox3.Clear();
            textbox4.Clear();

            DateTime from = Database.sooe_date.from_date;
            DateTime to = Database.sooe_date.to_date;
            int equity = 0;
            int withdrawals = 0;
            for (int i = 0; i < Database.TEntries.Count; i++)
            {
                Entry_tacc _tacc = Database.TEntries[i];
                DateTime td = _tacc.Date;
                if (td.Day >= from.Day && td.Month >= from.Month && td.Year >= from.Year &&
                    td.Day <= to.Day && td.Month <= to.Month && td.Year <= to.Year)
                {
                    if (_tacc.Type == "Owner's Equity") 
                    {
                        equity += _tacc.TotalCredit;
                        withdrawals += _tacc.TotalDebit;
                    }
                }
            }

            textbox1.Text = equity.ToString();
            textbox2.Text = Database.net_income.ToString();
            textbox3.Text = withdrawals.ToString();
            textbox4.Text = ((equity + Database.net_income) - withdrawals).ToString();
        }
        
        private void from_SelectionChanged(object sender, RoutedEventArgs e)
        {
            DateTime.TryParse(From.Text, out Database.sooe_date.from_date);
            Refresh();
        }
        
        private void to_SelectionChanged(object sender, RoutedEventArgs e)
        {
            DateTime.TryParse(To.Text, out Database.sooe_date.to_date);
            Refresh();
        }
    }
}
