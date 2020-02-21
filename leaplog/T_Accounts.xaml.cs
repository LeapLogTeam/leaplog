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
    /// Go ahead and write a summary for T_Accounts.xaml here!
    /// </summary>
    public partial class T_Accounts : UserControl
    {
        public T_Accounts()
        {
            InitializeComponent();
        }

        public void Refresh()
        {
            entryGrid.Items.Clear();
            for (int i = 0; i < Database.Entries.Count; i++)
            {
                entryGrid.Items.Add(Database.Entries[i]);
            }
        }
    }
}
