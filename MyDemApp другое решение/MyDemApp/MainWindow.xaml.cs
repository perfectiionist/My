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

namespace MyDemApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ClassFrame.frmObj = FrmMain;
        }

        private void BtnAuth_Click(object sender, RoutedEventArgs e)
        {
            if (TxbLogin.Text != "" && PsbPass.Password != "")
            {
                MessageBox.Show("Вход выполнен");
                ClassFrame.frmObj.Navigate(new Pages.PageView());
            }
            else
            {
                MessageBox.Show("Вход не выполнен. Заполните все поля!");
            }
        }
    }
}
