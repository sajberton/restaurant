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
        public DtoMenu()
        {
        }

        public DtoMenu(Menu menu)
        {
            Id = menu.Id;

            TypeEnum = (MenuType)menu.TypeId;
            RestaurantName = menu.RestaurantName;
        }

        public int Id { get; set; }

        public MenuType TypeEnum { get; set; }

        public string RestaurantName { get; set; }

    }
}
