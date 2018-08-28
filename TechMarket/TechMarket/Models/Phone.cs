using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TechMarket.Models
{
    public class Phone
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Model { get; set; }
        
        public int Price { get; set; }

    }
}