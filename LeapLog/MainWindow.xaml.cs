using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// The main window represents is used to navigate between User Controls.
    /// Each button makes a different section of our program visible.
    /// </summary>
   
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        //Button Click Events
        private void journalBtn_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(journalUserControl);
        }

        private void tAccBtn_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(t_AccountsUserControl);
        }

        public void SetActiveUserControl(UserControl control)
        {
            //make all user control sections invisible and collapsed
            journalUserControl.Visibility = Visibility.Collapsed;
            t_AccountsUserControl.Visibility = Visibility.Collapsed;

            //make the correct user control section visible
            control.Visibility = Visibility.Visible;
        }
    }
}
