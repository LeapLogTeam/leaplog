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
using Microsoft.Office.Interop.Excel;


namespace LeapLog
{
	 /// <summary>
	 /// Interaction logic for BalanceSheet.xaml
	 /// </summary>
	 public partial class BalanceSheet : UserControl
	 {
		public static string destinationText = Journal.passingText;
		
		public BalanceSheet()
		  {
			   InitializeComponent();
			   Database.select_date = DateTime.Now;
		  }

		  // method that refreshes the balancesheet grid so that it is updated with current t-account entries
		  public void Refresh()
		  {
			   // Clear all grids
			   entryGridA.Items.Clear();
			   entryGridTA.Items.Clear();
			   entryGridLO.Items.Clear();
			   entryGridTLO.Items.Clear();

			   int Total_assests = 0;
			   int Total_LOE = 0;

			   //add t-accounts to respective grids
			   for (int i = 0; i < Database.TEntries.Count; i++)
			   {
					Entry_tacc _tacc = Database.TEntries[i];
					DateTime td = _tacc.Date;
					DateTime date = Database.select_date;
					if (td.Day == date.Day && td.Month == date.Month && td.Year == date.Year)
					{
						 string type = _tacc.Type;
						 switch (type)
						 {
							  case "Asset":
								   entryGridA.Items.Add(_tacc);
								   Total_assests += _tacc.Balance;
								   break;
							  case "Liability":
								   entryGridLO.Items.Add(_tacc);
								   Total_LOE += _tacc.Balance;
								   break;
							  case "Owner's Equity":
								   entryGridLO.Items.Add(_tacc);
								   Total_LOE += _tacc.Balance;
								   break;
						 }
					}
			   }

			   // Add the totals
			   entryGridTA.Items.Add(new Total() { total = Total_assests });
			   entryGridTLO.Items.Add(new Total() { total = Total_LOE });
		  }

		  private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
		  {
			   // Update the calendar date and than refresh
			   Calendar calendar = sender as Calendar;
			   if (calendar.SelectedDate.HasValue)
			   {
					Database.select_date = calendar.SelectedDate.Value;
					Refresh();
			   }
		  }

		//method for when help feature button is clicked
		private void balanceHelpButton_Click(object sender, RoutedEventArgs e)
		{
			balanceHelpWindow.Visibility = Visibility.Visible;
		}

		//method for when help feature close button is clicked
		private void balanceCloseButton_Click(object sender, RoutedEventArgs e)
		{
			balanceHelpWindow.Visibility = Visibility.Collapsed;
		}

		
		}
	}

