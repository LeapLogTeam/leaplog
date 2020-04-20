using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Interaction logic for AdminLogin.xaml
    /// </summary>
    public partial class AdminLogin : Window
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void back2_Login_Click(object sender, RoutedEventArgs e)
        {


            LoginScreen MS = new LoginScreen();
            MS.Show();
            this.Hide();
        }

        private void enter_Button_Click(object sender, RoutedEventArgs e)
        {
         
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\ENGEL\ONEDRIVE\01LONESTAR\2020SPRING\INEW2332PROJECT\NEWGITHUBCLONE\LEAPLOG\LEAPLOG\LOGINDB\LOGINDB.MDF;Integrated Security=True");
            string query = "Select * from AdminLogin where username = '" + userName.Text.Trim() + "' and password = '" + Pass.Password.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            if (dataTable.Rows.Count == 1)
            {
                AddNewUser MS = new AddNewUser();
                MS.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(this, "Wrong User Name or Password", "Information");//, MessageBoxButtons.OK,
                                                                                    // MessageBoxIcon.Information);
                userName.Clear();
                Pass.Clear();
                userName.Focus();
            }

        }

        private void exit_Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
