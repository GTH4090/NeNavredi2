using Microsoft.Win32;
using NeNavredi.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
using static NeNavredi.Classes.Helper;

namespace NeNavredi.Pages
{
    /// <summary>
    /// Логика взаимодействия для ClientBill.xaml
    /// </summary>
    public partial class ClientBill : Page
    {
        bool load = false;
        List<OrderService> Services = new List<OrderService>();
        public ClientBill()
        {
            InitializeComponent();
        }
        private void loadData()
        {

            try
            {
                if (load)
                {
                    Services = Db.OrderService.ToList().Where(el =>
                    el.Order.Date >= FromDp.SelectedDate && el.Order.Date <= ToDp.SelectedDate && el.Order.Client
                    == OrganisationCbx.SelectedItem as Client).ToList();
                    ServiceDg.ItemsSource = Services;

                    FinalPriceLb.Content = Services.Sum(el => el.Service.Price);
                    PhoneTbx.Text = (OrganisationCbx.SelectedItem as Client).Phone;
                }
            }
            catch (Exception ex)
            {
                Error(ex.Message);
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                FromDp.SelectedDate = DateTime.Now.Date;
                ToDp.SelectedDate = DateTime.Now.Date;
                OrganisationCbx.ItemsSource = Db.Client.ToList();
                OrganisationCbx.SelectedIndex = 0;
                load = true;
                loadData();

            }
            catch (Exception ex)
            {
                Error(ex.Message);
            }
        }

        private void OrganisationCbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            loadData();

        }

        private void FromDp_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            loadData();

        }

        private void ToDp_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            loadData();

        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PrintDialog print = new PrintDialog();
                if (print.ShowDialog() == true)
                {
                    print.PrintVisual(MainGrid, "Счёт");
                }
                string csv = "ФИО;Телефон;Период для оплаты;Список услуг + цена(через запятую);финальная цена\r";
                csv += $"{(OrganisationCbx.SelectedItem as Client).Name};{PhoneTbx.Text};{FromDp.SelectedDate.ToString()}-{ToDp.SelectedDate.ToString()};" +
                    $"{string.Join(",", Services.Select(el => el.Service.Name + el.Service.Price))};{FinalPriceLb.Content}";

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = ".csv|*.csv";
                if (saveFile.ShowDialog() == true)
                {
                    File.WriteAllText(saveFile.FileName, csv);
                }
                NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                Error(ex.Message);
            }
        }
    }
}
