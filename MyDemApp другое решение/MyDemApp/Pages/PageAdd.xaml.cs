using MyDemApp.Data;
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

namespace MyDemApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAdd.xaml
    /// </summary>
    public partial class PageAdd : Page
    {
        ClassPerson _currentPerson = new ClassPerson();
        public int tt;
            
        public PageAdd(ClassPerson persontLocal)
        {
            if (persontLocal != null)
            {
                _currentPerson = persontLocal;

                tt = 0;
            }
            else tt = 1;

            DataContext = _currentPerson;
            InitializeComponent();
            cmbApplicationStatus.ItemsSource = new string[3] { "в ожидании", "в работе", "выполнено" };
        }
    

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (tt == 1)
            {
                ClassPerson.list.Add(new ClassPerson
                {
                    Id = Number.Text,
                    Date = Date.Text,
                    Equipment = Equipment.Text,
                    Malfunction_type = TypeOfFault.Text,
                    Problem_desc = Description.Text,
                    Client = ClientLastName.Text,
                    Status = cmbApplicationStatus.Text,
                });
                MessageBox.Show("Данные добавлены");
                ClassFrame.frmObj.Navigate(new Pages.PageView());
            }
            else
            {
                foreach (var item in ClassPerson.list)
                    if (item.Id == Number.Text)
                    {
                        item.Problem_desc = Description.Text;
                        item.Status = cmbApplicationStatus.Text;
                    }

                ClassFrame.frmObj.Navigate(new Pages.PageView());
            }
        }

    }
}
