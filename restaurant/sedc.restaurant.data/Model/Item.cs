using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sedc.restaurant.data.Model
{
   public class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Availability { get; set; }
        public string Description { get; set; }
        public string Contents { get; set; }
    }
}
