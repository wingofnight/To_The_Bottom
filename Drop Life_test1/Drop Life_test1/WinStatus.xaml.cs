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

namespace Drop_Life_test1
{
    /// <summary>
    /// Логика взаимодействия для WinStatus.xaml
    /// </summary>
    public partial class WinStatus : Window
    {
       public MainWindow Tranzit = new MainWindow();

        public WinStatus()
        {
            InitializeComponent();
        }

        

        private void btn_leave_Click(object sender, RoutedEventArgs e)
        {         
           Close();
        }
    }
}
