using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkDB.Model.Entity
{
    class Depot
    {      
        public int Id { get; set; }
       /* public int ProductId { get; set; }
        public int ComingProduct { get; set; }
        public int Standard { get; set; }
        public int Quantity { get; set; }
        public DateTime DateBringing { get; set; }
        */

        public Store Store { get; set; }
       
        public ICollection<Product> Products { get; set; }
 
        public Depot()
        {
            Products = new List<Product>();
        }
       
    }
}
