using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkDB.Model.Entity
{
    class Depot
    {
        public int Id { get; set; }
        public int Count { get; set; }

        public virtual ICollection<Product> ProductId { get; set; }

        public Depot()
        {
            ProductId = new List<Product>();
        }

        public override string ToString()
        {
            return Convert.ToString(Count);
        }
    }
}
