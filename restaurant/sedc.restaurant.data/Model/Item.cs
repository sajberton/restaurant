﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sedc.restaurant.data.Model
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int Availability { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        [MaxLength(2500)]
        public string Contents { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
