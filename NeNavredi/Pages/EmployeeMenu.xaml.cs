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
using System.Windows.Threading;
using static NeNavredi.Classes.Helper;

namespace NeNavredi.Pages
{
    /// <summary>
    /// Логика взаимодействия для EmployeeMenu.xaml
    /// </summary>
    public partial class EmployeeMenu : Page
    {
        int min = 2;
        DispatcherTimer timer = new DispatcherTimer(); 
        public EmployeeMenu()
        {
            InitializeComponent();
            timer.Interval = new TimeSpan(0, 1, 0);
            timer.Tick += Timer_Tick;
            LogoutTimer.Start();
            InfoTimer.Start();
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            min--;
            if(min >= 0)
            {
                TimerLb.Content = "0:" + min;
            }
            else
            {
                timer.Stop();
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            NameLb.Content = LoginedUs.Name;

        }
    }
}
