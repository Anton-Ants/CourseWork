using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkDB.Model.Entity
{
    class StoreDepot
    {
        public int Id { get; set; }
        public string ProductId { get; set; }
        public string SoldData { get; set; }
        public int Count { get; set; }
    }
}
