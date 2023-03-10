using Microsoft.EntityFrameworkCore;
using Start.Context;
using Start.Entites;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
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

namespace Start
{
    /// <summary>
    /// Interaction logic for FrontEndWindow.xaml
    /// </summary>
    public partial class FrontEndWindow : Window
    {
        public FrontEndWindow()
        {
            InitializeComponent();
            #region Reservation tab
            ComboEditReservation.Visibility = Visibility.Collapsed;
            btnUpdate.Visibility = Visibility.Collapsed;
            using HotelContext Context = new HotelContext();
            Context.Reservations.Load();
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

            //ComboRoom.SelectedIndex=0;
            //ComboDay.SelectedIndex = 0; 
            //comboMonth.SelectedIndex = 0;
            //ComboNoOfGuests.SelectedIndex = 0;
            //ComboFloorNo.SelectedIndex = 0;
            //ComboState.SelectedIndex = 0;
            //ComboGender.SelectedIndex = 0; 
            #endregion
            #region Search
            txtNotFound.Visibility = Visibility.Collapsed;
            GridSearch.Visibility = Visibility.Collapsed;
            #endregion

            #region Grid view
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
            GridReservation.ItemsSource = reservations;
            #endregion

            #region Room availability
            var reservedRooms = Context.Reservations.Where(r=>r.CheckIn == true).ToList();
            var occupiedRooms = Context.Reservations.Where(r=>r.CheckIn == false).ToList();
            ListOccupied.ItemsSource = occupiedRooms;
            ListReserved.ItemsSource = reservedRooms;
            #endregion
        }
       


        private void OnClickBtnNewReservation(object sender, RoutedEventArgs e)
        {
            string firstName = txtFName.Text;
            string lastName = txtLName.Text;
            int.TryParse(txtYear.Text,out int year);
            int.TryParse(ComboDay.SelectedValue.ToString(),out int day);
            int.TryParse(comboMonth.SelectedValue.ToString(),out int month);
            string birthDay = new DateOnly (year, month, day).ToString();
            string gender = ComboGender.SelectedValue.ToString();
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            int.TryParse(ComboNoOfGuests.SelectedValue.ToString(), out int noOfGuests);
            string street = txtStreet.Text;
            string suite = txtSuite.Text;
            string city = txtCity.Text;
            string state = ComboState.SelectedValue.ToString();
            int.TryParse(txtZipCode.Text,out int zipCode);
            string roomType = ComboRoom.SelectedValue.ToString();
            int.TryParse(ComboFloorNo.SelectedValue.ToString(),out int floor);
            int.TryParse(ComboRoomNo.SelectedValue.ToString(),out int roomNo);
            //float.TryParse(txt)
            //Reservation newReservation = new Reservation() { };
        }

        private void OnClickBtnSearch(object sender, RoutedEventArgs e)
        {
            using HotelContext Context = new HotelContext();
            Context.Reservations.Load();
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
    }
}
