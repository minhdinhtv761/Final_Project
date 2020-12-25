using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class FoodDrink
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FoodDrinkID { get; set; }
        [Required]
        public string FoodDrinkName { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }
        [Required]
        public bool IsAvailable { get; set; }
        [Required]
        public bool IsFood { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
