using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sedc.restaurant.data.Model
{
   public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Item> ListItems { get; set; }
    }
}
