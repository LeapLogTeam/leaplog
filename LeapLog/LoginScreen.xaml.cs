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
using System.Windows.Shapes;


namespace LeapLog
{
    /// <summary>
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        public object MessageBoxIcon { get; private set; }

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            if (UserName.Text == "leaplog" && Pass.Text == "leaplog")
            {
                MainWindow MS = new MainWindow();
                MS.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(this, "Wrong User Name or Password", "Information");//, MessageBoxButtons.OK,
               // MessageBoxIcon.Information);
                UserName.Clear();
                Pass.Clear();
                UserName.Focus();
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
