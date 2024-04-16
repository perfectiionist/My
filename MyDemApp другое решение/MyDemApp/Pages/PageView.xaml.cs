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
using System.Collections.ObjectModel;
using MyDemApp;
using MyDemApp.ViewModel;
using MyDemApp.Data;

namespace MyDemApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageView.xaml
    /// </summary>
    public partial class PageView : Page
    {

       
        public PageView()
        {
            InitializeComponent();


            dtgListPerson.ItemsSource = ClassPerson.list;     
        }

        private void PageView_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new PersonsViewModel();
        }

        

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.frmObj.Navigate(new PageAdd(null));
        }
    }
}
