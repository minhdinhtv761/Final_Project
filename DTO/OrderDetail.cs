using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderDetail
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int OrderDetailID { get; set; }
        [Key, Column(Order = 0)]
        public int OrderID { get; set; }
        [Key, Column(Order = 1)]
        public int FoodDrinkID { get; set; }
        [Required]
        public int Quantity { get; set; }
        public string Note { get; set; }
        [Required]
        public float Price { get; set; }

    }
}
