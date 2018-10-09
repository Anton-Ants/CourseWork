﻿using System;
using CourseWorkDB.Model.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkDB.Model.Logic
{
    class Saver
    {
        ShopContext db = new ShopContext();
        ProductType type = new ProductType ();
        

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
            db.Depot.Add(depot);
        }

        public void SaveDb()
        {
            db.SaveChanges();
        }
    }
}
