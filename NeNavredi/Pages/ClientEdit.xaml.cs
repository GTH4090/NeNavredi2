using NeNavredi.Models;
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
using System.Windows.Shapes;
using static NeNavredi.Classes.Helper;

namespace NeNavredi.Pages
{
    /// <summary>
    /// Логика взаимодействия для ClientEdit.xaml
    /// </summary>
    public partial class ClientEdit : Window
    {
        public ClientEdit()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            try
            {
                var items = Db.Organisation.ToList();
                items.Insert(0, new Models.Organisation() { Name = "Нет" });
                organisationIdCbx.ItemsSource = items;
                organisationIdCbx.SelectedIndex = 0;
                grid1.DataContext = new Client();
                birthDateDatePicker.SelectedDate = DateTime.Now;
            }
            catch (Exception ex)
            {
                Error(ex.Message);
            }
           
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if(organisationIdCbx.SelectedIndex == 0)
                {
                    (grid1.DataContext as Client).Organisation = null;
                }
                Db.Client.Add(grid1.DataContext as Client);
                Db.SaveChanges();

                Close();
            }
            catch (Exception ex)
            {
                Error(ex.Message);
            }
        }
    }
}
