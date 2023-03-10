using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
using Microsoft.EntityFrameworkCore;
using Start.Context;


namespace Start
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lblError.Content = "";
        }
        private Container components = null;

        private void UsernameChanged(object sender, TextChangedEventArgs e)
        {
            if (txtUsername.Text.Length == 0)
            {
                txtBlockUsrnm.Visibility = Visibility.Visible;
            }
            else
            {
                txtBlockUsrnm.Visibility = Visibility.Collapsed;
            }
        }

        private void PasswordChanged(object sender, DataTransferEventArgs e) // does't work
        {
            if (sender is PasswordBox passwordBox)
            {
                txtUsername.Text = passwordBox.Password.ToString();
                //if (passwordBox.SecurePassword.Length == 0)
                //{
                //    txtBlockPassword.Visibility = Visibility.Visible;
                //}
                //else
                //{
                //    txtBlockUsrnm.Visibility = Visibility.Collapsed;
                //}
            }
        }

        private void ShowLicense(object sender, RoutedEventArgs e)
        {
            LicenceWindow licenceWindow = new LicenceWindow();
            licenceWindow.ShowDialog();
        }

        private void OnClosing(object sender, CancelEventArgs e)
        {
            if (!e.Cancel && components != null)
            {
                components.Dispose();
            }
        }

        private void btnSigninClicked(object sender, RoutedEventArgs e)
        {
            string usrnm = txtUsername.Text;
            string password = txtPassword.Password.ToString();
            //Debug.WriteLine(usrnm);
            //Debug.WriteLine(password);
            using HotelContext Context = new HotelContext();
            Context.Managers.Load();
            Context.Kitchens.Load();

            var managers = (from m in Context.Managers
                           select new { m.User_name, m.Pass_word }).ToList();
            var Kitchens = (from k in Context.Kitchens
                           select new { k.User_name, k.Pass_word }).ToList();

            bool found = false;
            if (usrnm.Length != 0 && password.Length != 0)
            {
                foreach(var person in managers)
                {
                    if(person.User_name == usrnm && person.Pass_word == password)
                    {
                        found = true;
                        FrontEndWindow FrontendWindow = new FrontEndWindow();
                        this.Close();
                        FrontendWindow.Show();
                    }
                }
                if(found == false)
                {
                    foreach (var person in Kitchens)
                    {
                        if (person.User_name == usrnm && person.Pass_word == password)
                        {
                            found = true;
                            RoomService RoomServiceWindow = new RoomService();
                            this.Close();
                            RoomServiceWindow.Show();
                        }
                    }
                }
                if (found == false)
                {
                    lblError.Content = "Please Make Sure again";
                }
                //// should be modified to db
                //if (usrnm == "admin" && password == "admin")
                //{

                //}
                //else if (usrnm == "_kitchen" && password == "kitchen_")
                //{
                //    RoomService RoomServiceWindow = new RoomService();
                //    this.Close();
                //    RoomServiceWindow.Show();
                //}
            }
        }

    }
}
