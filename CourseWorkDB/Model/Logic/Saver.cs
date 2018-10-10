using System;
using CourseWorkDB.Model.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkDB.Model.Logic
{
    class Saver
    {
        ShopContext db = null;
       


        public Saver(ShopContext shopContext)
        {
            db = shopContext;
        }

        public void AddType(ProductType type)
        {
            db.ProductTypes.Add(type);
        }

        public void AddProduct(Product product)
        {
            db.Products.Add(product);
        }

        public void AddDepot(Depot depot)
        {
            db.Depots.Add(depot);
        }

        public void AddStore(Store store)
        {
            db.Stores.Add(store);
        }
        public void SaveDb()
        {
            db.SaveChanges();
        }
    }
}
