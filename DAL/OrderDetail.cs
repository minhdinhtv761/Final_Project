using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class OrderDetail
    {
        public int OrderID { get; set; }
        public int FoodDrinkID { get; set; }
        public int Quantity { get; set; }
        public string Note { get; set; }
        public float Price { get; set; }

        public virtual FoodDrink FoodDrink { get; set; }
        public virtual Order Order { get; set; }
    }
}
