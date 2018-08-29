using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sedc.restaurant.data.Model
{
   public class Menu
    {
        public int Id { get; set; }
        public Enum Type { get; set; }
        public string RestaurantName { get; set; }
        public List<Category> Categorys { get; set; }
    }

    enum Type
    {
        Meals,
        Drinks,
        Wines
    }
}
