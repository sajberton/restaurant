using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sedc.restaurant.data.Model
{
   public class Order
    {
        public int Quantity { get; set; }
        public int TotalQuantity { get; set; }
        public int Table { get; set; }
        public double TotalPrice { get; set; }
        public string Comment { get; set; }
        public Enum Status { get; set; }
        public DateTime Created { get; set; }

    }

    enum Status
    {
        Created,
        Inprogres,
        Prepared,
        Delivered
    }
}
