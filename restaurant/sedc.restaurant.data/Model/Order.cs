using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sedc.restaurant.data.Model
{
   public class Order
    {
        [Required]
        public int Id { get; set; }       

        [Required]
        [MaxLength(3)]
        public int Table { get; set; }

        [Required]
        public byte StatusId { get; set; }

        public string Comments { get; set; }    

        [Required]
        public DateTime WhenCreated { get; set; }

        public List<OrderItem> ListOrderItem { get; set; }

        public int? TotalQuantity => ListOrderItem?.Sum(loi => loi.Quantity);

        public double? TotalPrice => ListOrderItem?.Sum(loi => loi.Quantity * loi.Item.Price);
    }

    
}
