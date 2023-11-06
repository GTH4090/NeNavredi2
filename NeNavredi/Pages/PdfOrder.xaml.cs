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
using System.Windows.Shapes;
using static NeNavredi.Classes.Helper;

namespace NeNavredi.Pages
{
    /// <summary>
    /// Логика взаимодействия для PdfOrder.xaml
    /// </summary>
    public partial class PdfOrder : Window
    {
        Order _order;
        public PdfOrder(Order order)
        {
            _order = order;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            try
            {
                grid1.DataContext = _order;

                PrintDialog print = new PrintDialog();
                if(print.ShowDialog() == true)
                {
                    print.PrintVisual(grid1, "заказ");
                }

                string base64 = "Дата Заказа;Номер Заказа;Предприятие; ФИО;Дата рождения;Перечень услуг и цены (через запятую)\n";
                base64 += $"{_order.Date};{_order.Code};{(_order.Client.Organisation != null ? _order.Client.Organisation.Name : " ")};{_order.Client.Name};{_order.Client.BirthDate};{string.Join(",",_order.OrderService.Select(el => el.Service.Name + " " + el.Service.Price))}";

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = ".txt|*.txt";
                if(saveFile.ShowDialog() == true)
                {
                    File.WriteAllText(saveFile.FileName,Convert.ToBase64String(Encoding.UTF8.GetBytes(base64)));
                }
                Close();

            }
            catch (Exception ex)
            {
                Error(ex.Message);
            }
           
        }
    }
}
