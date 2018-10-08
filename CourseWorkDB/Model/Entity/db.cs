using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkDB.Model.Entity
{
    class ShopContext : DbContext
    {
        public ShopContext()
          : base("DbConnection")
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
    }
}
