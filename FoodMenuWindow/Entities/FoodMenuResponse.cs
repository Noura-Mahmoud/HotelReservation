using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start.FoodMenuWindow.Entities
{

    [NotMapped]
    public class FoodMenuResponse
    {
        public bool breakfast { get; set; }
        public bool lunch { get; set; }
        public bool dinner { get; set; }
        public bool cleaning { get; set; }
        public bool towels { get; set; }
        public bool surprise { get; set; }
        public int breakfastQuantity { get; set; }
        public int lunchQuantity { get; set; }
        public int dinnerQuantity { get; set; }
        
    }
}
