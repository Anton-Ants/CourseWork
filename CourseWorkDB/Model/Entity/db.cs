using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkDB.Model.Entity
{
    class db : DbContext
    {
        public db()
          : base("DbConnection")
        { }

        public DbSet<db> Users { get; set; }
    }
}
