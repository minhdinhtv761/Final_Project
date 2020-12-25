using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class BookingTable
    {
        public int CustomerID { get; set; }
        public int TableID { get; set; }
        public System.DateTime BookingDate { get; set; }
        public System.DateTime ExpiredTime { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Table Table { get; set; }
    }
}
