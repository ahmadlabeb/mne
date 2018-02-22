using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace systemBuy.Models
{
    public class systemBuyContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
        public systemBuyContext() : base("name=systemBuyContext")
        {
        }

        public DbSet<systemBuy.Models.bills> bills { get; set; }

        public DbSet<systemBuy.Models.items> items { get; set; }
    }
}
