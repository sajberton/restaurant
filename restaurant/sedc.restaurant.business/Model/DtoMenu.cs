using sedc.restaurant.data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sedc.restaurant.business.Model
{
   public class DtoMenu
    {
        public int Id { get; set; }
        public Type TypeEnum { get; set; }
        public string RestaurantName { get; internal set; }

        public DtoMenu()
        {
        }

        public DtoMenu(Menu menu)
        {
            Id = menu.Id;

            TypeEnum = (Type)menu.TypeId;
            RestaurantName = menu.RestaurantName;
        }

        public enum Type
        {
            Meals,
            Drinks,
            Wines
        }
    }
}
