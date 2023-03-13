using Start.PaymentWindow.Entities;
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
using System.Windows.Shapes;

namespace Start
{
    /// <summary>
    /// Interaction logic for FinalizeBillWindow.xaml
    /// </summary>
    public partial class FinalizeBillWindow : Window
    {
        public Payment paymentDetails;
        public FinalizeBillWindow()
        {
            InitializeComponent();
            List<string> paymentType = new List<string>() { "Debit", "Credit", "Cash"};
            ComboPaymentType.ItemsSource = paymentType;
            List<int> Months = Enumerable.Range(1, 13).ToList();
            ComboMonth.ItemsSource = Months;
            List<int> Years = Enumerable.Range(1990, DateTime.Now.Year).ToList();
            ComboYear.ItemsSource = Years;
            
        }

        private void getDetailsFromFront()
        {
            try
            {
                paymentDetails = new Payment();
                //double.TryParse(lblReservationBill.Content.ToString(), out double roomBill);
                double roomBill = Convert.ToDouble(lblReservationBill.Content.ToString());
                double roomTax = roomBill * 0.07;
                int.TryParse(lblFoodBill.Content.ToString(), out int foodBill);
                double Total = roomBill + roomTax + foodBill;
                lblCurrentBill.Content = roomBill;
                lblTax.Content = roomTax;
                lblTotal.Content = Total;
                paymentDetails.Total = Total;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
        private void OnClickBtnBillNext(object sender, RoutedEventArgs e)
        {
            try
            {
                paymentDetails.PaymentType = ComboPaymentType.SelectedValue.ToString();
                paymentDetails.paymentCardNumber = txtPaymentCardNumber.Text;
                paymentDetails.MM_YY_Of_Card = ComboMonth.SelectedValue.ToString() + "/" + ComboYear.SelectedValue.ToString();
                paymentDetails.CVC_Of_Card = txtCVC.Text;
                paymentDetails.CardType = lblCardType.Content.ToString();
                this.Close();
            }
            catch (Exception)
            {
                MessageBoxResult result = MessageBox.Show(this, "Error while getting Payment details",
                                            "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                //throw;
            }
        }

        private void OnChangingMonth(object sender, SelectionChangedEventArgs e)
        {
            //lblCardType.Content = txtPaymentCardNumber.Text.Substring(1, 1);
            //if (txtPaymentCardNumber.Text.Substring(1, 1) == "3")
            //{
            //    lblCardType.Content = "AmericanExpress";
            //}
            //else if (txtPaymentCardNumber.Text.Substring(1, 1) == "4")
            //{
            //    lblCardType.Content = "Visa";
            //}
            //else if (txtPaymentCardNumber.Text.Substring(1, 1) == "5")
            //{
            //    lblCardType.Content = "MasterCard";
            //}
            //else if (txtPaymentCardNumber.Text.Substring(1, 1) == "6")
            //{
            //    lblCardType.Content = "Discover";
            //}
            //else
            //    lblCardType.Content = "Unknown";
        }

        private void OnLeaveCardNumber(object sender, RoutedEventArgs e)
        {
            string cardNum = KeepNumbersOnly(txtPaymentCardNumber.Text);
            txtPaymentCardNumber.Text = string.Format("{0:0000-0000-0000-0000}", cardNum);
            if (txtPaymentCardNumber.Text.Substring(1, 1) == "3")
            {
                lblCardType.Content = "AmericanExpress";
            }
            else if (txtPaymentCardNumber.Text.Substring(1, 1) == "4")
            {
                lblCardType.Content = "Visa";
            }
            else if (txtPaymentCardNumber.Text.Substring(1, 1) == "5")
            {
                lblCardType.Content = "MasterCard";
            }
            else if (txtPaymentCardNumber.Text.Substring(1, 1) == "6")
            {
                lblCardType.Content = "Discover";
            }
            else
                lblCardType.Content = "Unknown";
        }

        public string KeepNumbersOnly(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9'))
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        private void OnChangingPaymentType(object sender, SelectionChangedEventArgs e)
        {
            getDetailsFromFront();
        }
    }
}
