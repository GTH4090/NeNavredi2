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

namespace NeNavredi
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                MainFrame.GoBack();
            }
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            LoginedUs = null;
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                BackBtn.Visibility = Visibility.Visible;

            }
            else
            {
                BackBtn.Visibility = Visibility.Collapsed;
            }
            TitleLb.Content = (e.Content as Page).Title;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LogoutTimer.Tick += LogoutTimer_Tick;
            InfoTimer.Tick += InfoTimer_Tick;
            MainMainFrame = MainFrame;
        }

       
    }
}
