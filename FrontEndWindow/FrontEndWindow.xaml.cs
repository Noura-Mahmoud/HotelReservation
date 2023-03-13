using Microsoft.EntityFrameworkCore;
using Start.Context;
using Start.Entites;
using Start.FoodMenuWindow.Entities;
using Start.PaymentWindow.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
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
    /// Interaction logic for FrontEndWindow.xaml
    /// </summary>
    public partial class FrontEndWindow : Window
    {
        HotelContext Context;
        Reservation reservation;
        int foodBill;
        Payment payment;
        FoodMenuResponse menuResponse ;
        public FrontEndWindow()
        {
            InitializeComponent();
            Context = new HotelContext();
            reservation = new Reservation();
            foodBill = new int();
            payment = new Payment();
            menuResponse = new FoodMenuResponse();
            Context.Reservations.Load();

            #region Reservation tab
            ReservationTabInitializations();
            #endregion

            #region Search
            SearchTabInitializations();
            #endregion

            #region Grid view
            LoadDataToGridView();
            #endregion

            #region Room availability
            LoadRoomAvailablityTab();
            #endregion
        }
        private void ReservationTabInitializations()
        {
            try
            {
                ClearTextBoxes(GridReservationInputs);
                //ClearComboBoxes(GridReservationInputs);

                Context = new HotelContext();
                Context.Reservations.Load();
                EntryDate.DisplayDate = DateTime.Today;
                DepartureDate.DisplayDate = DateTime.Today.AddDays(1);
                //lblChoices.Foreground = Brushes.Black;
                btnDelete.Visibility = Visibility.Collapsed;
                ComboEditReservation.Visibility = Visibility.Collapsed;
                btnUpdate.Visibility = Visibility.Collapsed;
                //Context.Reservations.Load()
                List<string> RoomType = new List<string>() { "Single", "Double", "Twin", "Duplex", "Suite" };
                ComboRoom.ItemsSource = RoomType;
                // For combobox of Days
                List<int> Days = Enumerable.Range(1, 32).ToList();
                ComboDay.ItemsSource = Days;
                // For combobox of Months
                List<int> Months = Enumerable.Range(1, 13).ToList();
                comboMonth.ItemsSource = Months;
                // For combobox of NoOfGuests
                List<int> NoOfGuests = Enumerable.Range(1, 7).ToList();
                ComboNoOfGuests.ItemsSource = NoOfGuests;
                // For combobox of FloorNo
                List<int> FloorNo = Enumerable.Range(1, 6).ToList();
                ComboFloorNo.ItemsSource = FloorNo;
                // For combobox of States
                var States = (from r in Context.Reservations
                              select new { r.State }).Distinct().ToList();
                ComboState.ItemsSource = States;
                ComboState.DisplayMemberPath = "State";
                ComboState.SelectedValuePath = "State";
                // Get available rooms 
                var occupiedRooms = Context.Reservations.Where(r => r.CheckIn == false).ToList();
                ComboRoomNo.ItemsSource = occupiedRooms;
                ComboRoomNo.DisplayMemberPath = "RoomNumber";

                CheckCheckin.IsChecked = false;
                CheckFoodSupply.IsChecked = false;
                CheckSendSMS.IsChecked = false;

                

                //ComboRoom.SelectedIndex=0;
                //ComboDay.SelectedIndex = 0; 
                //comboMonth.SelectedIndex = 0;
                //ComboNoOfGuests.SelectedIndex = 0;
                //ComboFloorNo.SelectedIndex = 0;
                //ComboState.SelectedIndex = 0;
                //ComboGender.SelectedIndex = 0; 
            }
            catch (Exception)
            {
                MessageBoxResult result = MessageBox.Show(this, "Make Sure of stablishing connection with Database",
                                            "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                //throw;
            }
        }
        private void SearchTabInitializations()
        {
            txtNotFound.Visibility = Visibility.Collapsed;
            GridSearch.Visibility = Visibility.Collapsed;
        }
        private void LoadDataToGridView()
        {
            try
            {
                var reservations = (from r in Context.Reservations
                                    select new
                                    {
                                        r.FirstName,
                                        r.LastName,
                                        r.BirthDay,
                                        r.Gender,
                                        r.PhoneNumber,
                                        r.EmailAddress,
                                        r.NumberGuest,
                                        r.StreetAddress,
                                        r.AptSuite,
                                        r.City,
                                        r.State,
                                        r.ZipCode,
                                        r.RoomType,
                                        r.RoomFloor,
                                        r.RoomNumber,
                                        r.TotalBill,
                                        r.PaymentType,
                                        r.CardType,
                                        r.CardNumber,
                                        r.CardExp,
                                        r.CardCvc,
                                        r.ArrivalTime,
                                        r.LeavingTime,
                                        r.CheckIn,
                                        r.BreakFast,
                                        r.Lunch,
                                        r.Dinner,
                                        r.Cleaning,
                                        r.Towel,
                                        r.SSurprise,
                                        r.SupplyStatus,
                                        r.FoodBill
                                    }).ToList();
                GridReservation.Items.Clear();
                GridReservation.ItemsSource = reservations;
            }
            catch (Exception)
            {
                MessageBoxResult result = MessageBox.Show(this, "Make Sure of stablishing connection with Database",
                                            "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                //throw;
            }
        }
        private void LoadRoomAvailablityTab()
        {
            try
            {
                var reservedRooms = Context.Reservations.Where(r => r.CheckIn == true).ToList();
                var occupiedRooms = Context.Reservations.Where(r => r.CheckIn == false).ToList();
                ListOccupied.Items.Clear();
                ListReserved.Items.Clear();
                ListOccupied.ItemsSource = occupiedRooms;
                ListReserved.ItemsSource = reservedRooms;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
        private void OnClickBtnNewReservation(object sender, RoutedEventArgs e)
        {
            
            ClearTextBoxes(GridReservationInputs);
            btnUpdate.Visibility = Visibility.Collapsed;
            btnDelete.Visibility = Visibility.Collapsed;
            btnSubmit.Visibility = Visibility.Visible;

            #region old code
            //string firstName = txtFName.Text;
            //string lastName = txtLName.Text;
            //int.TryParse(txtYear.Text, out int year);
            //int.TryParse(ComboDay.SelectedValue.ToString(), out int day);
            //int.TryParse(comboMonth.SelectedValue.ToString(), out int month);
            //string birthDay = new DateOnly(year, month, day).ToString();
            //string gender = ComboGender.SelectedValue.ToString();
            //string phone = txtPhone.Text;
            //string email = txtEmail.Text;
            //int.TryParse(ComboNoOfGuests.SelectedValue.ToString(), out int noOfGuests);
            //string street = txtStreet.Text;
            //string suite = txtSuite.Text;
            //string city = txtCity.Text;
            //string state = ComboState.SelectedValue.ToString();
            //int.TryParse(txtZipCode.Text, out int zipCode);
            //string roomType = ComboRoom.SelectedValue.ToString();
            //int.TryParse(ComboFloorNo.SelectedValue.ToString(), out int floor);
            //int.TryParse(ComboRoomNo.SelectedValue.ToString(), out int roomNo); 
            #endregion
            
            //float.TryParse(txt)
            //Reservation newReservation = new Reservation() { };
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
        }

        //Clear Comboboxes
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

        //in Search tab
        private void OnClickBtnSearch(object sender, RoutedEventArgs e)
        {
            using HotelContext Context = new HotelContext();
            //Context.Reservations.Load();
            var reservations = Context.Reservations.Where(r => r.FirstName.ToLower() == txtSearch.Text.ToLower()
                                                            || r.LastName.ToLower() == txtSearch.Text.ToLower()
                                                            || r.BirthDay.ToLower() == txtSearch.Text.ToLower()
                                                            || r.Gender.ToLower() == txtSearch.Text.ToLower()
                                                            || r.PhoneNumber.ToLower() == txtSearch.Text.ToLower()
                                                            || r.EmailAddress.ToLower() == txtSearch.Text.ToLower()
                                                            || r.StreetAddress.ToLower() == txtSearch.Text.ToLower()
                                                            || r.AptSuite.ToLower() == txtSearch.Text.ToLower()
                                                            || r.City.ToLower() == txtSearch.Text.ToLower()
                                                            || r.State.ToLower() == txtSearch.Text.ToLower()
                                                            || r.ZipCode.ToLower() == txtSearch.Text.ToLower()
                                                            || r.RoomType.ToLower() == txtSearch.Text.ToLower()
                                                            || r.RoomFloor.ToLower() == txtSearch.Text.ToLower()
                                                            || r.RoomNumber.ToLower() == txtSearch.Text.ToLower()
                                                            || r.TotalBill.ToString().ToLower() == txtSearch.Text.ToLower()
                                                            || r.PaymentType.ToLower() == txtSearch.Text.ToLower()
                                                            || r.CardType.ToLower() == txtSearch.Text.ToLower()
                                                            || r.CardNumber.ToLower() == txtSearch.Text.ToLower()
                                                            || r.CardExp.ToLower() == txtSearch.Text.ToLower()
                                                            || r.CardCvc.ToLower() == txtSearch.Text.ToLower()
                                                            || r.ArrivalTime.ToString().ToLower() == txtSearch.Text.ToLower()
                                                            || r.LeavingTime.ToString().ToLower() == txtSearch.Text.ToLower()
                                                            || r.BreakFast.ToString().ToLower() == txtSearch.Text.ToLower()
                                                            || r.Lunch.ToString().ToLower() == txtSearch.Text.ToLower()
                                                            || r.Dinner.ToString().ToLower() == txtSearch.Text.ToLower()
                                                            || r.FoodBill.ToString().ToLower() == txtSearch.Text.ToLower()
                                                            ).ToList();
            if(reservations.Count() > 0)
            {
                txtNotFound.Visibility = Visibility.Collapsed;
                GridSearch.ItemsSource = reservations;
                GridSearch.Visibility = Visibility.Visible;
            }
            else
            {
                GridSearch.Visibility = Visibility.Collapsed;
                txtNotFound.Visibility = Visibility.Visible;
            }
        }
        // Food and menu window
        private void OnClickBtnFoodAndMenu(object sender, RoutedEventArgs e)
        {
            FoodMenu foodMenu = new FoodMenu();
            foodMenu.ShowDialog();
            menuResponse= new FoodMenuResponse
            {
                //breakfast = foodMenu.response.breakfast,
                //lunch = foodMenu.response.lunch,
                //dinner = foodMenu.response.dinner,
                cleaning = foodMenu.response.cleaning,
                towels = foodMenu.response.towels,
                surprise = foodMenu.response.surprise,
                breakfastQuantity = foodMenu.response.breakfastQuantity,
                lunchQuantity = foodMenu.response.lunchQuantity,
                dinnerQuantity = foodMenu.response.dinnerQuantity
            };


            if (menuResponse.breakfastQuantity > 0 || menuResponse.lunchQuantity > 0 || menuResponse.dinnerQuantity > 0)
            {
                int bfastBill = 7 * menuResponse.breakfastQuantity;
                int lunchBill = 15 * menuResponse.lunchQuantity;
                int dinnerBill = 15 * menuResponse.dinnerQuantity;
                foodBill = bfastBill + lunchBill + dinnerBill;
            }
            // test
            //txtFName.Text = foodMenu.response.breakfastQuantity.ToString();
        }
        private void OnClickBtnEditReservation(object sender, RoutedEventArgs e)
        {
            btnDelete.Visibility = Visibility.Visible;
            btnUpdate.Visibility = Visibility.Visible;
            btnSubmit.Visibility = Visibility.Collapsed;
            ComboEditReservation.Visibility = Visibility.Visible;
            var reserved = Context.Reservations.Where(r => r.CheckIn == true).ToList();
            ComboEditReservation.ItemsSource = reserved;
            ComboEditReservation.DisplayMemberPath = "FirstName";
            ComboEditReservation.SelectedValuePath = "Id";

            ClearTextBoxes(GridReservationInputs);
            ClearComboBoxes(GridReservationInputs);
        }
        private void OnClickBtnSubmit(object sender, RoutedEventArgs e)
        {
            
            SaveReservationData();
            //newReservation.ArrivalTime =(DateTime)DepartureDate.Text;
            try
            {
                Context.Add(reservation);
                Context.SaveChanges();
                ReservationTabInitializations();
                LoadDataToGridView();
                LoadRoomAvailablityTab();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void SaveReservationData()
        {
            reservation = new Reservation();
            reservation.FirstName = txtFName.Text;
            reservation.LastName = txtLName.Text;
            int.TryParse(txtYear.Text, out int year);
            int.TryParse(ComboDay.SelectedValue.ToString(), out int day);
            int.TryParse(comboMonth.SelectedValue.ToString(), out int month);
            reservation.BirthDay = new DateOnly(year, month, day).ToString();
            //newReservation.BirthDay = ComboDay.SelectedValue.ToString()+"/"+comboMonth.SelectedValue.ToString()+"/"+txtYear.Text;
            reservation.Gender = ComboGender.SelectedItem.ToString();
            reservation.PhoneNumber = txtPhone.Text;
            reservation.EmailAddress = txtEmail.Text;
            int.TryParse(ComboNoOfGuests.SelectedValue.ToString(), out int noOfGuests);
            reservation.NumberGuest = noOfGuests;
            reservation.StreetAddress = txtStreet.Text;
            reservation.AptSuite = txtSuite.Text;
            reservation.City = txtCity.Text;
            reservation.State = ComboState.SelectedValue.ToString();
            //int.TryParse(txtZipCode.Text, out int zipCode);
            reservation.ZipCode = txtZipCode.Text;
            reservation.RoomType = ComboRoom.SelectedValue.ToString();
            //int.TryParse(ComboFloorNo.SelectedValue.ToString(), out int floor);
            reservation.RoomFloor = ComboFloorNo.SelectedValue.ToString();
            //int.TryParse(ComboRoomNo.SelectedValue.ToString(), out int roomNo);
            reservation.RoomNumber = ComboRoomNo.SelectedItem.ToString();
            reservation.TotalBill = (float)payment.Total;
            reservation.PaymentType = payment.PaymentType;
            reservation.CardType = payment.CardType;
            reservation.CardNumber = payment.paymentCardNumber;
            reservation.CardExp = payment.MM_YY_Of_Card;
            reservation.CardCvc = payment.CVC_Of_Card;
            reservation.ArrivalTime = Convert.ToDateTime(EntryDate.Text);
            reservation.LeavingTime = Convert.ToDateTime(DepartureDate.Text);
            reservation.CheckIn = (bool)CheckCheckin.IsChecked;
            reservation.BreakFast = menuResponse.breakfastQuantity;
            reservation.Lunch = menuResponse.lunchQuantity;
            reservation.Dinner = menuResponse.dinnerQuantity;
            reservation.SupplyStatus = (bool)CheckFoodSupply.IsChecked;
            reservation.Cleaning = menuResponse.cleaning;
            reservation.Towel = menuResponse.towels;
            reservation.SSurprise = menuResponse.surprise;
            reservation.FoodBill = payment.FoodBill;
        }
        public int roomPrice = 0;
        private void OnChangingRoomType(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (ComboRoom.SelectedValue.Equals("Single"))
                {
                    roomPrice = 149;
                    ComboFloorNo.SelectedValue = "1";
                }
                else if (ComboRoom.SelectedValue.Equals("Double"))
                {
                    roomPrice = 299;
                    ComboFloorNo.SelectedValue = "2";
                }
                else if (ComboRoom.SelectedValue.Equals("Twin"))
                {
                    roomPrice = 349;
                    ComboFloorNo.SelectedValue = "3";
                }
                else if (ComboRoom.SelectedValue.Equals("Duplex"))
                {
                    roomPrice = 399;
                    ComboFloorNo.SelectedValue = "4";
                }
                else if (ComboRoom.SelectedValue.Equals("Suite"))
                {
                    roomPrice = 499;
                    ComboFloorNo.SelectedValue = "5";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            int selectedTemp = 0;
            string selected; 
            try
            {
                int.TryParse(ComboNoOfGuests.SelectedItem.ToString(), out selectedTemp);
                selected = ComboNoOfGuests.SelectedItem.ToString();
                int.TryParse(selected, out selectedTemp);
                //selectedTemp = Convert.ToInt32(selected);
                if (selectedTemp >= 3)
                {
                    roomPrice += (selectedTemp * 5);
                }
            }
            catch (Exception)
            {
                MessageBoxResult result = MessageBox.Show("Enter # of guests first");
                //throw;
            }
        }

        private void OnClickFinalizeBill(object sender, RoutedEventArgs e)
        {
            try
            {

                FinalizeBillWindow finalizeBillWindow = new FinalizeBillWindow();
                finalizeBillWindow.Owner = this;
                finalizeBillWindow.lblReservationBill.Content = roomPrice;
                finalizeBillWindow.lblFoodBill.Content = foodBill;
                finalizeBillWindow.ShowDialog();
                payment = new Payment();
                payment = new Payment
                {
                    PaymentType = finalizeBillWindow.paymentDetails.PaymentType,
                    paymentCardNumber = finalizeBillWindow.paymentDetails.paymentCardNumber,
                    MM_YY_Of_Card = finalizeBillWindow.paymentDetails.MM_YY_Of_Card,
                    CVC_Of_Card = finalizeBillWindow.paymentDetails.CVC_Of_Card,
                    CardType = finalizeBillWindow.paymentDetails.CardType,
                    Total = finalizeBillWindow.paymentDetails.Total,
                    FoodBill = finalizeBillWindow.paymentDetails.FoodBill
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
        //public int GetRoomPrice()
        //{
        //    return roomPrice;
        //}
        
        /// <summary>
        /// //////////////////////////////////////////////////////????????????????????????????????
        /// </summary>
        /// <param name="NotifiedID"></param>
        private void SendSMS(int NotifiedID)
        {
            string AccountSid = "ACcb86dacb791bef978628a2e16b1f7a24";
            string AuthToken = "3f344a07336d2e0ac5e467f72a1e650d";
            //creating an instance of twilio rest
            
            //var twilio = new TwilioRestClient(AccountSid, AuthToken);
            //string name = firstNameTextBox.Text + " " + lastNameTextBox.Text;

            //string end_num = paymentCardNumber.Substring(paymentCardNumber.Length - Math.Min(4, paymentCardNumber.Length));

            //if (smsCheckBox.Checked)
            //{
            //    //building message for twilio
            //    string buildMesage = "Hello " + name + "! Your unique ID# " + secondUserID + " Total bill of $" + finalizedTotalAmount + " is charged on your card # ending-" + end_num;
            //    //creating message 
            //    var message = twilio.SendMessage("+12034562736", RecvPhoneNumber, buildMesage, "");
            //    //sending message
            //    Console.WriteLine(message.Sid);
            //    smsCheckBox.Text = "SMS Sent";
            //}

        }

        private void OnCheckCheckin(object sender, RoutedEventArgs e)
        {
            CheckCheckin.Content = "Checked in";
        }

        private void OnUncheckCheckin(object sender, RoutedEventArgs e)
        {
            CheckCheckin.Content = "Check in?";
        }

        private void OnUncheckFoodSupply(object sender, RoutedEventArgs e)
        {
            CheckFoodSupply.Content = "Food/Supply status?";
        }

        private void OnCheckedFoodSupply(object sender, RoutedEventArgs e)
        {
            CheckFoodSupply.Content = "Food/Supply: Complete";
        }

        private void OnChangingReservationToBeEdited(object sender, SelectionChangedEventArgs e)
        {
            FillEditingReservationData();
        }
        private void FillEditingReservationData()
        {
            int.TryParse(ComboEditReservation.SelectedValue.ToString(), out int CurrentId);
            var currentReservation = Context.Reservations.FirstOrDefault(r => r.Id == CurrentId);
            //Reservation currentReservation = (Reservation)reservation;
            if(currentReservation != null)
            {
                try
                {
                    txtFName.Text = currentReservation.FirstName;
                    txtLName.Text = currentReservation.LastName;
                    ComboDay.Text = currentReservation.BirthDay.Substring(0, currentReservation.BirthDay.IndexOf('-')).Trim();
                    comboMonth.Text = currentReservation.BirthDay.Substring(currentReservation.BirthDay.IndexOf('-') + 1, 2).Trim();
                    txtYear.Text = currentReservation.BirthDay.Substring(currentReservation.BirthDay.Length - Math.Min(4, currentReservation.BirthDay.Length)).Trim();

                    ComboGender.Text = currentReservation.Gender.Trim();
                    txtPhone.Text = currentReservation.PhoneNumber;
                    txtEmail.Text = currentReservation.EmailAddress;

                    ComboNoOfGuests.SelectedItem = currentReservation.NumberGuest;
                    txtStreet.Text = currentReservation.StreetAddress;
                    txtSuite.Text = currentReservation.AptSuite;
                    txtCity.Text = currentReservation.City;
                    ComboState.SelectedValue = currentReservation.State;
                    txtZipCode.Text = currentReservation.ZipCode;
                    ComboRoom.SelectedItem = currentReservation.RoomType.Trim();
                    ComboFloorNo.Text = currentReservation.RoomFloor;
                    //int.TryParse(ComboRoomNo.SelectedValue.ToString(), out int roomNo);
                    //ComboRoomNo.SelectedItem = currentReservation.RoomNumber.Trim();
                    ComboRoomNo.Text = currentReservation.RoomNumber.Trim();
                    payment.Total = currentReservation.TotalBill;
                    payment.PaymentType = currentReservation.PaymentType;
                    payment.CardType = currentReservation.CardType;
                    payment.paymentCardNumber = currentReservation.CardNumber;
                    payment.MM_YY_Of_Card = currentReservation.CardExp;
                    payment.CVC_Of_Card = currentReservation.CardCvc;
                    EntryDate.Text = currentReservation.ArrivalTime.ToString();
                    DepartureDate.Text = currentReservation.LeavingTime.ToString();
                    CheckCheckin.IsChecked = currentReservation.CheckIn;
                    menuResponse.breakfastQuantity = currentReservation.BreakFast;
                    menuResponse.lunchQuantity = currentReservation.Lunch;
                    menuResponse.dinnerQuantity = currentReservation.Dinner;
                    CheckFoodSupply.IsChecked = currentReservation.SupplyStatus;
                    menuResponse.cleaning = currentReservation.Cleaning;
                    menuResponse.towels = currentReservation.Towel;
                    menuResponse.surprise = currentReservation.SSurprise;
                    payment.FoodBill = currentReservation.FoodBill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }
            }
            else
            {
                MessageBox.Show("Null");
            }
        }

        private void OnClickBtnUpdate(object sender, RoutedEventArgs e)
        {
            SaveReservationData();
            try
            {
                var toBeUpdated = Context.Reservations.FirstOrDefault(r => r.Id == reservation.Id);
                if(toBeUpdated != null)
                {
                    // toBeUpdated = reservation;
                    toBeUpdated.FirstName = reservation.FirstName;
                    toBeUpdated.LastName = reservation.LastName;
                    toBeUpdated.BirthDay = reservation.BirthDay;
                    toBeUpdated.Gender = reservation.Gender;
                    toBeUpdated.PhoneNumber = reservation.PhoneNumber;
                    toBeUpdated.EmailAddress = reservation.EmailAddress;
                    toBeUpdated.NumberGuest = reservation.NumberGuest;
                    toBeUpdated.StreetAddress = reservation.StreetAddress;
                    toBeUpdated.AptSuite = reservation.AptSuite;
                    toBeUpdated.City = reservation.City;
                    toBeUpdated.State = reservation.State;
                    toBeUpdated.ZipCode = reservation.ZipCode;
                    toBeUpdated.RoomType = reservation.RoomType;
                    toBeUpdated.RoomFloor = reservation.RoomFloor;
                    toBeUpdated.RoomNumber = reservation.RoomNumber;
                    toBeUpdated.TotalBill = reservation.TotalBill;
                    toBeUpdated.PaymentType = reservation.PaymentType;
                    toBeUpdated.CardType = reservation.CardType;
                    toBeUpdated.CardNumber = reservation.CardNumber;
                    toBeUpdated.CardExp = reservation.CardExp;
                    toBeUpdated.CardCvc = reservation.CardCvc;
                    toBeUpdated.ArrivalTime = reservation.ArrivalTime;
                    toBeUpdated.LeavingTime = reservation.LeavingTime;
                    toBeUpdated.CheckIn = reservation.CheckIn;
                    toBeUpdated.BreakFast = reservation.BreakFast;
                    toBeUpdated.Lunch = reservation.Lunch;
                    toBeUpdated.Dinner = reservation.Dinner;
                    toBeUpdated.Cleaning = reservation.Cleaning;
                    toBeUpdated.Towel = reservation.Towel;
                    toBeUpdated.SSurprise = reservation.SSurprise;
                    toBeUpdated.SupplyStatus = reservation.SupplyStatus;
                    toBeUpdated.FoodBill = reservation.FoodBill;
                }

                Context.SaveChanges();
                ReservationTabInitializations();
                LoadDataToGridView();
                LoadRoomAvailablityTab();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void OnClickBtnDelete(object sender, RoutedEventArgs e)
        {
            int.TryParse(ComboEditReservation.SelectedValue.ToString(), out int CurrentId);
            Reservation currentReservation = Context.Reservations.FirstOrDefault(r => r.Id == CurrentId);
            //Reservation currentReservation = (Reservation)reservation;
            try
            {
                Context.Remove(currentReservation);
                Context.SaveChanges();
                ReservationTabInitializations();
                //ClearTextBoxes(GridReservationInputs);
                //btnUpdate.Visibility = Visibility.Collapsed;
                //btnDelete.Visibility = Visibility.Collapsed;
                //btnSubmit.Visibility = Visibility.Visible;

                LoadDataToGridView();
                LoadRoomAvailablityTab();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
    }
}
