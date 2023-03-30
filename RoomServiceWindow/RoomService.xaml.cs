using Microsoft.EntityFrameworkCore;
using Start.Context;
using Start.Entites;
using Start.FoodMenuWindow.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace Start
{
    /// <summary>
    /// Interaction logic for RoomService.xaml
    /// </summary>
    public partial class RoomService : Window
    {
        HotelContext Context;
        Reservation reservation;
        FoodMenuResponse menuResponse;
        float totalBill;
        int foodBill;
        bool supply_status;
        int id;
        public RoomService()
        {
            InitializeComponent();
            formInitialization();
        }

        private void formInitialization()
        {
            Context = new HotelContext();
            reservation = new Reservation();
            menuResponse = new FoodMenuResponse();
            CheckFoodSupply.IsChecked = false;
            Context.Reservations.Load();
            loadDataToGrid();
            loadDataToListbox();
            ClearComboBoxes(gridRoomService);
            ClearTextBoxes(gridRoomService);
            ClearCheckBoxes(gridRoomService);
            checkCleaning.Content = "Cleaning";
            checkTowels.Content = "Towels";
            checkSurprise.Content = "Sweetest Surprise";
        }

        private void loadDataToGrid()
        {
            try
            {
                var reservations = (from r in Context.Reservations
                                    where r.CheckIn == true && r.SupplyStatus == false
                                    select new
                                    {
                                        r.Id,
                                        r.FirstName,
                                        r.LastName,
                                        r.PhoneNumber,
                                        r.RoomType,
                                        r.RoomFloor,
                                        r.RoomNumber,
                                        r.TotalBill,
                                        r.BreakFast,
                                        r.Lunch,
                                        r.Dinner,
                                        r.Cleaning,
                                        r.Towel,
                                        r.SSurprise,
                                        r.SupplyStatus,
                                        r.FoodBill
                                    }).ToList();
                overviewGrid.ItemsSource = reservations;
            }
            catch (Exception ex)
            {
                MessageBoxResult result = MessageBox.Show(ex.Message);
                //MessageBoxResult result = MessageBox.Show(this, "Make Sure of stablishing connection with Database",
                //                            "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                //throw;
            }
        }


        
        
        private void loadDataToListbox()
        {
            try
            {
                var listboxData = (from r in Context.Reservations
                                   where r.CheckIn == true && r.SupplyStatus == false
                                   select new
                                   {
                                       r.Id,
                                       r.FirstName,
                                       r.LastName,
                                       r.PhoneNumber
                                   }).ToList();
                listboxReservations.ItemsSource = listboxData;
                listboxReservations.DisplayMemberPath = "FirstName";
                listboxReservations.SelectedValuePath = "Id";
            }
            catch (Exception ex)
            {
                MessageBoxResult result = MessageBox.Show(ex.Message);
                //MessageBoxResult result = MessageBox.Show(this, "Make Sure of stablishing connection with Database",
                //                            "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                //throw;
            }
        }

        private void btnChangeFoodSelection_Click(object sender, RoutedEventArgs e)
        {
            FoodMenu foodMenu = new FoodMenu();
            foodMenu.needsBorder.Visibility = Visibility.Hidden;

            foodMenu.txtBreakfastQuantity.Text = menuResponse.breakfastQuantity.ToString();
            foodMenu.txtLunchQuantity.Text = menuResponse.lunchQuantity.ToString();
            foodMenu.txtDinnerQuantity.Text = menuResponse.dinnerQuantity.ToString();
            foodMenu.checkTowels.IsChecked = menuResponse.towels;
            foodMenu.checkSurprise.IsChecked = menuResponse.surprise;
            foodMenu.checkCleaning.IsChecked = menuResponse.cleaning;


            foodMenu.ShowDialog();
            menuResponse.breakfastQuantity = int.Parse(foodMenu.txtBreakfastQuantity.Text.ToString());
            menuResponse.lunchQuantity = int.Parse(foodMenu.txtLunchQuantity.Text.ToString());
            menuResponse.dinnerQuantity = int.Parse(foodMenu.txtDinnerQuantity.Text.ToString());

            int bfast = 0, Lnch = 0, di_ner = 0;
            if (menuResponse.breakfastQuantity > 0)
            {
                bfast = 7 * menuResponse.breakfastQuantity;
            }
            if (menuResponse.lunchQuantity > 0)
            {
                Lnch = 15 * menuResponse.lunchQuantity;
            }
            if (menuResponse.dinnerQuantity > 0)
            {
                di_ner = 15 * menuResponse.dinnerQuantity;
            }
            foodBill += (bfast + Lnch + di_ner);
        }

        private void btnUpdateChanges_Click(object sender, RoutedEventArgs e)
        {
            reservation = Context.Reservations.FirstOrDefault(r => r.Id == id);
            if (reservation != null)
            {
                reservation.FoodBill = foodBill;
                reservation.TotalBill = totalBill;
                reservation.Towel = menuResponse.towels;
                reservation.Cleaning = menuResponse.cleaning;
                reservation.SSurprise = menuResponse.surprise;
                reservation.Lunch = menuResponse.lunchQuantity;
                reservation.BreakFast = menuResponse.breakfastQuantity;
                reservation.Dinner = menuResponse.dinnerQuantity;
                reservation.SupplyStatus = supply_status;
                //reservation.SupplyStatus = CheckFoodSupply.IsChecked??false;
                try
                {
                    Context.SaveChanges();
                    MessageBox.Show("updated succcessfully");
                    formInitialization();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void OnCheckedFoodSupply(object sender, RoutedEventArgs e)
        {
            supply_status = !supply_status;
            //checkCleaning.IsChecked = !checkCleaning.IsChecked;
            //checkTowels.IsChecked = !checkTowels.IsChecked;
            //checkSurprise.IsChecked = !checkSurprise.IsChecked;
            if (supply_status)
            {
                checkCleaning.Content = "Cleaned";
                checkTowels.Content = "Toweled";
                checkSurprise.Content = "Surprised";
            }
            else
            {
                checkCleaning.Content = "Cleaning";
                checkTowels.Content = "Towels";
                checkSurprise.Content = "Sweetest Surprise";
            }
        }

        private void listboxReservations_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(listboxReservations.SelectedItems.Count > 0)
            {
                var res = Context.Reservations.FirstOrDefault(r => r.Id == int.Parse( listboxReservations.SelectedValue.ToString()));
                txtFName.Text = res.FirstName;
                txtLName.Text = res.LastName;
                txtPhone.Text = res.PhoneNumber;
                txtRoomNumber.Text = res.RoomNumber;
                txtRoomType.Text = res.RoomType;
                txtFloorNumber.Text = res.RoomFloor;
                txtBreakfast.Text = res.BreakFast.ToString();
                txtLunch.Text = res.Lunch.ToString();
                txtDinner.Text = res.Dinner.ToString();
                checkTowels.IsChecked = res.Towel;
                checkSurprise.IsChecked = res.SSurprise;
                checkCleaning.IsChecked = res.Cleaning;
                totalBill = res.TotalBill;
                foodBill = res.FoodBill;
                totalBill -= foodBill;
                id = res.Id;
                menuResponse.breakfastQuantity = res.BreakFast;
                menuResponse.lunchQuantity = res.Lunch;
                menuResponse.dinnerQuantity = res.Dinner;
                menuResponse.towels = res.Towel;
                menuResponse.surprise = res.SSurprise;
                menuResponse.cleaning = res.Cleaning;
            }
        }

        private void ClearComboBoxes(DependencyObject parent)
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(parent, i);
                if (child is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)child;
                    comboBox.SelectedIndex = -1;
                }
                else
                {
                    ClearComboBoxes(child);
                }
            }
        }

        private void ClearTextBoxes(DependencyObject parent)
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(parent, i);
                if (child is TextBox)
                {
                    TextBox textBox = (TextBox)child;
                    textBox.Text = "";
                }
                else
                {
                    ClearTextBoxes(child);
                }
            }
            //txtFName.Text = txtLName.Text = txtYear.Text = txtPhone.Text = txtEmail.Text = txtStreet.Text = txtCity.Text = txtSuite.Text = txtZipCode.Text = string.Empty;
        }

        private void ClearCheckBoxes(DependencyObject parent)
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(parent, i);
                if (child is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)child;
                    checkBox.IsChecked = false;
                }
                else
                {
                    ClearCheckBoxes(child);
                }
            }
        }
    }

}


