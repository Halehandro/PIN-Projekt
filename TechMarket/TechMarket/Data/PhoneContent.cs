using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TechMarket.Models;

namespace TechMarket.Data
{
    public class PhoneContent : DbContext
    {
        public PhoneContent() : base("DefaultConnection")
        {
            
        }
        public DbSet<Phone> Phones { get; set; }
    }
}