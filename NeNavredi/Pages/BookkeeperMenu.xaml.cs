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
    /// Логика взаимодействия для BookkeeperMenu.xaml
    /// </summary>
    public partial class BookkeeperMenu : Page
    {
        public BookkeeperMenu()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            NameLb.Content = LoginedUs.Name;

        }
    }
}
