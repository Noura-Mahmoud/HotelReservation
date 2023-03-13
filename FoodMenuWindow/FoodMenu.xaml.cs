using Start.FoodMenuWindow.Entities;
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
    /// Interaction logic for FoodMenu.xaml
    /// </summary>
    public partial class FoodMenu : Window
    {
        public FoodMenuResponse response;
        public FoodMenu()
        {
            InitializeComponent();
            txtBreakfastQuantity.Text = "1";
            txtLunchQuantity.Text = "1";
            txtDinnerQuantity.Text = "1";
            txtBreakfastQuantity.IsEnabled = false;
            txtLunchQuantity.IsEnabled = false;
            txtDinnerQuantity.IsEnabled = false;
        }

        #region food and menu selection


        //private int lunchQ = 0;

        //public int LunchQ
        //{
        //    get { return lunchQ; }
        //    set { lunchQ = value; }
        //}
        //private int breakfastQ = 0;

        //public int BreakfastQ
        //{
        //    get { return breakfastQ; }
        //    set { breakfastQ = value; }
        //}
        //private int dinnerQ = 0;

        //public int DinnerQ
        //{
        //    get { return dinnerQ; }
        //    set { dinnerQ = value; }
        //}

        //private string cleaning = "";

        //public string Cleaning
        //{
        //    get { return cleaning; }
        //    set { cleaning = value; }
        //}
        //private string towel = "";

        //public string Towel
        //{
        //    get { return towel; }
        //    set { towel = value; }
        //}

        //private string surprise = "";

        //public string Surprise
        //{
        //    get { return surprise; }
        //    set { surprise = value; }
        //}

        #endregion
        private void OnClickBtnNext(object sender, RoutedEventArgs e)
        {
            response = new FoodMenuResponse();

            if ((bool)CheckBreakfast.IsChecked)
            {
                int.TryParse(txtBreakfastQuantity.Text, out int QuantityBreakfast);
                response.breakfastQuantity = QuantityBreakfast;
            }
            else
            {
                response.breakfastQuantity = 0;
            }
            if ((bool)CheckLunch.IsChecked)
            {
                int.TryParse(txtLunchQuantity.Text, out int QuantityLunch);
                response.lunchQuantity = QuantityLunch;
            }
            else
            {
                response.lunchQuantity = 0;
            }
            if ((bool)CheckDinner.IsChecked)
            {
                int.TryParse(txtDinnerQuantity.Text, out int QuantityDinner);
                response.dinnerQuantity = QuantityDinner;
            }
            else
            {
                response.dinnerQuantity = 0;
            }
            if ((bool)checkCleaning.IsChecked)
            {
                response.cleaning = (bool)checkCleaning.IsChecked;
            }
            if ((bool)checkTowels.IsChecked)
            {
                response.towels = (bool)checkTowels.IsChecked;
            }
            if ((bool)checkSurprise.IsChecked)
            {
                response.surprise = (bool)checkSurprise.IsChecked;
            }
            #region mine

            //int.TryParse(txtBreakfastQuantity.Text, out int QuantityBreakfast);
            //int.TryParse(txtLunchQuantity.Text, out int QuantityLunch);
            //int.TryParse(txtDinnerQuantity.Text, out int QuantityDinner);

            //response = new FoodMenuResponse();
            ////response.breakfast = (bool)CheckBreakfast.IsChecked;
            ////response.lunch = (bool)CheckLunch.IsChecked;
            ////response.dinner = (bool)CheckDinner.IsChecked;
            //response.breakfastQuantity = QuantityBreakfast;
            //response.lunchQuantity = QuantityLunch;
            //response.dinnerQuantity = QuantityDinner;
            //response.cleaning = (bool)checkCleaning.IsChecked;
            //response.towels = (bool)checkTowels.IsChecked;
            //response.surprise = (bool)checkSurprise.IsChecked; 
            #endregion

            this.Close();
        }

        private void CheckedBreakfast(object sender, RoutedEventArgs e)
        {
            txtBreakfastQuantity.IsEnabled = true;
        }

        private void CheckedLunch(object sender, RoutedEventArgs e)
        {
            txtLunchQuantity.IsEnabled = true;
        }
        private void CheckedDinner(object sender, RoutedEventArgs e)
        {
            txtDinnerQuantity.IsEnabled = true;
        }

        private void UnchekedLunch(object sender, RoutedEventArgs e)
        {
            txtLunchQuantity.IsEnabled = false;
        }

        private void UnchekedBreakfast(object sender, RoutedEventArgs e)
        {
            txtBreakfastQuantity.IsEnabled = false;
        }

        private void UnchekedDinner(object sender, RoutedEventArgs e)
        {
            txtDinnerQuantity.IsEnabled = false;
        }

    }
}
