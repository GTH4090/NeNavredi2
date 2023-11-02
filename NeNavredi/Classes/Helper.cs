using NeNavredi.Models;
using NeNavredi.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Windows.Threading;

namespace NeNavredi.Classes
{
    internal class Helper
    {
        public static NeNavrediEntities Db = new NeNavrediEntities();

        public static User LoginedUs = null;

        public static bool CanLogin = true;

        public static Frame MainMainFrame = null;

        static DispatcherTimer calloginTimer = new DispatcherTimer();

        public static DispatcherTimer LogoutTimer = new DispatcherTimer() { Interval = new TimeSpan(0, 2, 0),};

        public static void LogoutTimer_Tick(object sender, EventArgs e)
        {
            
            calloginTimer.Interval = new TimeSpan(0, 1, 0);
            calloginTimer.Tick += CalloginTimer_Tick;
            CanLogin = false;
            LoginedUs = null;
            MainMainFrame.Navigate(new Auth());
            calloginTimer.Start();
        }

        private static void CalloginTimer_Tick(object sender, EventArgs e)
        {
            CanLogin = true;
            calloginTimer.Stop();
        }

        public static DispatcherTimer InfoTimer = new DispatcherTimer() { Interval = new TimeSpan(0, 1, 0), };

        public static void InfoTimer_Tick(object sender, EventArgs e)
        {
            Info("Осталась 1 минута/ 15 минут");
            InfoTimer.Stop();
        }



        public static void Error(string message = "Ошибка подключения к БД")
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        public static void Info(string message = "Ошибка подключения к БД")
        {
            MessageBox.Show(message, "Инфо", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
