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
        public string productId { get; set; }
        public decimal count { get; set; }
        public string data { get; set; }
        public string storeId { get; set; }
    }
}
