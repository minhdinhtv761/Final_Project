using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class FoodDrink
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FoodDrink()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }

        public int FoodDrinkID { get; set; }
        public string FoodDrinkName { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsFood { get; set; }
        public Nullable<double> FoodPrice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
