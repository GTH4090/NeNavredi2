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
    /// Логика взаимодействия для EnterHistoryPage.xaml
    /// </summary>
    public partial class EnterHistoryPage : Page
    {
        public EnterHistoryPage()
        {
            InitializeComponent();
        }

        private void loadData()
        {

            try
            {
                List<EnterHistory> enterHistories = Db.EnterHistory.ToList();
                if(LoginSearchTbx.Text.Length> 0)
                {
                    enterHistories = enterHistories.Where(el => el.Login.Contains(LoginSearchTbx.Text)).ToList();
                }
                if(SortCbx.SelectedIndex == 0)
                {
                    enterHistories = enterHistories.OrderBy(el => el.Date).ToList();
                }
                else
                {
                    enterHistories = enterHistories.OrderByDescending(el => el.Date).ToList();
                }
                enterHistoryDataGrid.ItemsSource = enterHistories;

            }
            catch (Exception ex)
            {
                Error(ex.Message);
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            SortCbx.SelectedIndex = 0;
            loadData();
        }

        private void LoginSearchBtn_TextChanged(object sender, TextChangedEventArgs e)
        {
            loadData();
        }

        private void SortCbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            loadData();
        }
    }
}
