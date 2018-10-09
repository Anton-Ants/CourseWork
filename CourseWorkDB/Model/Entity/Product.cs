using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkDB.Model.Entity
{
    class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public decimal Cost { get; set; }

        public int? ProductTypeId { get; set; }
        public virtual ProductType ProductType { get; set; }

      
        public virtual Depot Depot { get; set; }

        
    }
}
