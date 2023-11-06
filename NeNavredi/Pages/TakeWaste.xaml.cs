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
using System.Windows.Navigation;
using System.Windows.Shapes;
using static NeNavredi.Classes.Helper;

namespace NeNavredi.Pages
{
    /// <summary>
    /// Логика взаимодействия для TakeWaste.xaml
    /// </summary>
    public partial class TakeWaste : Page
    {
        public TakeWaste()
        {
            InitializeComponent();
        }

        private void loadData()
        {

            try
            {

                List<Client> clients = Db.Client.ToList();
                List<Service> services = Db.Service.ToList();

                if (ClientSearchTbx.Text.Length > 0)
                {
                    clients = clients.Where(el => el.Name.Contains(ClientSearchTbx.Text) || el.Login.Contains(ClientSearchTbx.Text) || el.Email.Contains(ClientSearchTbx.Text) ||
                    el.Organisation.Name.Contains(ClientSearchTbx.Text) || el.Phone.Contains(ClientSearchTbx.Text) || el.PassportNumber.Contains(ClientSearchTbx.Text) || el.PassportSerial.Contains(ClientSearchTbx.Text)).ToList();
                }
                if (ServiceSearchTbx.Text.Length > 0)
                {
                    services = services.Where(el => el.Name.Contains(ServiceSearchTbx.Text) || el.AvarageDeviation.ToString().Contains(ServiceSearchTbx.Text) || el.Price.ToString().Contains(ServiceSearchTbx.Text)).ToList();
                }

                ServiceCbx.ItemsSource = services;
                ClientCbx.ItemsSource = clients;

                ClientCbx.SelectedIndex = 0;
                ServiceCbx.SelectedIndex = 0;
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
                MainGrid.DataContext = new Order();
                loadData();
                if (Db.Order.Count() > 0)
                {
                    CodeTbx.Text = (Db.Order.OrderByDescending(el => el.Id).FirstOrDefault().Code + 1).ToString("D6");
                }
                else
                {
                    CodeTbx.Text = "000001";
                }
            }
            catch (Exception ex)
            {
                Error(ex.Message);
            }
        }

        private void ClientSearchTbx_KeyDown(object sender, KeyEventArgs e)
        {

            try
            {
                if (e.Key == Key.Enter)
                {
                    string min = "qwertyuiopasdfghjklzxcvbnmйцукенгшщзхъфывапролджэячсмитьбю";
                    string big = min.ToUpper();

                    if (CodeTbx.Text.Intersect(big).Count() == 0 && CodeTbx.Text.Intersect(min).Count() == 0)
                    {
                        CodeTbx.IsEnabled = false;
                        ModeSp.Visibility = Visibility.Visible;
                        PrintDialog print = new PrintDialog();

                        if (print.ShowDialog() == true)
                        {
                            print.PrintVisual(BarcodeImg, "Штрихкод");
                        }
                        (MainGrid.DataContext as Order).Code = Convert.ToInt32(CodeTbx.Text);
                    }
                    else
                    {
                        Error("Неподходяший код");
                    }
                }
            }
            catch (Exception ex)
            {
                Error(ex.Message);
            }
        
                
        }

        private void AddserviceBtn_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if(ServiceCbx.SelectedItem != null)
                {
                    var item = ServiceCbx.SelectedItem as Service;
                    OrderService orderService = new OrderService();
                    orderService.Service = item;
                    orderService.StatusId = 1;
                    (MainGrid.DataContext as Order).OrderService.Add(orderService);
                    ServiceDg.ItemsSource = (MainGrid.DataContext as Order).OrderService.ToList();
                    FinalPriceLb.Content = (MainGrid.DataContext as Order).OrderService.Sum(el => el.Service.Price);
                }
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
                (MainGrid.DataContext as Order).Date = DateTime.Now;
                (MainGrid.DataContext as Order).StatusId = 1;
                (MainGrid.DataContext as Order).Client = ClientCbx.SelectedItem as Client;
                (MainGrid.DataContext as Order).Time = (int)(MainGrid.DataContext as Order).OrderService.Sum(el => el.Service.Time.TotalMinutes);

                Db.Order.Add(MainGrid.DataContext as Order);
                Db.SaveChanges();

                PdfOrder pdf = new PdfOrder(MainGrid.DataContext as Order);
                pdf.ShowDialog();
                NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                Error(ex.Message);
            }
        }

        private void ServiceSearchTbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            loadData();
        }

        private void ClientSearchTbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            loadData();
        }

        private void NewClientBtn_Click(object sender, RoutedEventArgs e)
        {
            ClientEdit clientEdit = new ClientEdit();
            clientEdit.ShowDialog();
            loadData();
        }
    }
}
