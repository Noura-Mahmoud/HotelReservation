using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start.PaymentWindow.Entities
{
    public class Payment
    {
        public string PaymentType { get; set; }
        public string paymentCardNumber { get; set; }
        public string MM_YY_Of_Card { get; set; }
        public string CVC_Of_Card { get; set; }
        public string CardType { get; set; }
        public double Total { get; set; }
        public int FoodBill { get; set; }
    }
}
