using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkDB.Model.Entity
{
    class GoodsSold
    {
        public int Id { get; set; }
        public string ProductId { get; set; }
        public int Count { get; set; }
        public string Data { get; set; }
        public string StoreId { get; set; }

        public Store Store { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public GoodsSold()
        {
            Products = new List<Product>();

        }

    }
}
