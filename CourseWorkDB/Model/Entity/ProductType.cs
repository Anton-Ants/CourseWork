using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWorkDB.Model.Entity
{
    class ProductType
    {
 
        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public ProductType()
        {
            Products = new List<Product>();
        }

        public override string ToString()
        {
            return Type;
        }
    }
}
