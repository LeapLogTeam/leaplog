using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for AddNewUser.xaml
    /// </summary>
    public partial class AddNewUser : Window
    {
        public AddNewUser()
        {
            InitializeComponent();
        }



        private void exitButton_Click_1(object sender, RoutedEventArgs e)
        {
            // this.Close();
            //Process.GetCurrentProcess().Close();
            Environment.Exit(Environment.ExitCode);




        }

        private void backToLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginScreen MS = new LoginScreen();
            MS.Show();
            this.Hide();
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                //our code here
                // this.Close();
                Environment.Exit(Environment.ExitCode);
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            LoginManager sqlTables = new LoginManager();

            string messageBoxText = "Username and password fields cannot be null or empty.";
            string messageBoxText2 = "Username and password have been added.";
            string caption = "Wrong Input";
            string caption2 = "User Added";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Information;

            //<<------- this chooses the table where the data will be added to-------->>
            string username = newUsername.Text.Replace(" ", "");
            string password = newPass.Password.ToString();

            if (String.IsNullOrEmpty(username) || username == "")
            {
                MessageBox.Show(messageBoxText, caption, button, icon);
            }
            else if (String.IsNullOrEmpty(password) || password == "")
            {
                MessageBox.Show(messageBoxText, caption, button, icon);
            }
            else
            {
                sqlTables.WriteData("INSERT INTO UserLogin VALUES ('" + username + "','" + password + "')");
                MessageBox.Show(messageBoxText2, caption2, button, icon);
            }
            newUsername.Clear();
            newPass.Clear();

        }
    }
}
