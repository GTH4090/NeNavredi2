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
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Page
    {
        bool isCapcha = false;
        DispatcherTimer timer = new DispatcherTimer();
        public Auth()
        {
            InitializeComponent();
            timer.Interval = new TimeSpan(0, 0, 10);
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            CanLogin = true;
            timer.Stop();
        }

        private void capcha()
        {

            try
            {
                Random rd = new Random();
                CapchaGb.Visibility = Visibility.Visible;

                OneImg.Visibility = Visibility.Collapsed;
                TwoImg.Visibility = Visibility.Collapsed;
                ThreeImg.Visibility = Visibility.Collapsed;

                int num = rd.Next(3);
                if(num == 0)
                {
                    OneImg.Visibility = Visibility.Visible;
                }
                if(num == 1)
                {
                    TwoImg.Visibility = Visibility.Visible;
                }
                if( num == 2)
                {
                    ThreeImg.Visibility = Visibility.Visible;
                }
            }
            catch (Exception ex)
            {
                Error(ex.Message);
            }
        }

        private void PasswordTbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(PasswordPbx.Password != PasswordTbx.Text)
            {
                PasswordPbx.Password = PasswordTbx.Text;

            }
        }

        private void PasswordPbx_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if(PasswordPbx.Password != PasswordTbx.Text)
            {
                PasswordTbx.Text = PasswordPbx.Password;
            }

                
        }

        private void PasswordBtn_Click(object sender, RoutedEventArgs e)
        {
            if(PasswordPbx.Visibility != Visibility.Visible)
            {
                PasswordPbx.Visibility = Visibility.Visible;
                PasswordTbx.Visibility = Visibility.Collapsed;
            }
            else
            {
                PasswordPbx.Visibility = Visibility.Collapsed;
                PasswordTbx.Visibility = Visibility.Visible;
            }
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (CanLogin)
                {
                    if (isCapcha)
                    {
                        if(OneImg.Visibility == Visibility.Visible)
                        {
                            if(CapchaTbx.Text != "A123")
                            {
                                return;
                            }
                        }
                        if (TwoImg.Visibility == Visibility.Visible)
                        {
                            if (CapchaTbx.Text != "B456")
                            {
                                return;
                            }
                        }
                        if (ThreeImg.Visibility == Visibility.Visible)
                        {
                            if (CapchaTbx.Text != "C789")
                            {
                                return;
                            }
                        }
                    }

                    if(Db.User.FirstOrDefault(el => el.Login == LoginTbx.Text && el.Password == PasswordTbx.Text) != null)
                    {
                        var item = Db.User.FirstOrDefault(el => el.Login == LoginTbx.Text && el.Password == PasswordTbx.Text);
                        LoginedUs = item;
                        if(item.Employee != null)
                        {
                            NavigationService.Navigate(new EmployeeMenu());
                        }
                        if(item.ExplorerEmployee != null)
                        {
                            NavigationService.Navigate(new ExpEmploueeMenu());
                        }
                        if(item.Bookkeeper != null)
                        {
                            NavigationService.Navigate(new BookkeeperMenu());
                        }
                        if(item.Admin != null)
                        {
                            NavigationService.Navigate(new AdminMenu());
                        }
                    }
                    else
                    {
                        Info("Не правильный логин или пароль");
                        isCapcha = true;
                        CanLogin = false;
                        timer.Start();
                        capcha();
                    }
                }
                else
                {
                    Info("Авторизация пока запрещена");
                }
            }
            catch (Exception ex)
            {
                Error(ex.Message);
            }
        }

        private void CapchaBtn_Click(object sender, RoutedEventArgs e)
        {
            capcha();
        }
    }
}
