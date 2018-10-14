using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseWorkDB.Model.Entity;
using CourseWorkDB.Model.Logic;

namespace CourseWorkDB
{
    static class Controller
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ProductForm());

            using (ShopContext db = new ShopContext())
            {
                Saver saver = new Saver(db);
                              
                /*ProductType type1 = new ProductType{ Type = "Крупы" };
                ProductType type2 = new ProductType { Type = "Напитки" };
                saver.AddType(type1);
                saver.AddType(type2);

                Product product1 = new Product { Name = "Крупа гречневая «Бабушкина кухня»", Weight = 0.7, Cost = 1.35m, ProductType = type1  };
                Product product2 = new Product { Name = "Крупа гречневая «Фермер»", Weight = 0.9, Cost = 1.09m, ProductType = type1 };
                Product product3 = new Product { Name = "Квас «Лидский» хлебный", Weight = 1.5, Cost = 1.65m, ProductType = type2};
                Product product4 = new Product { Name = "Напиток «Pepsi»", Weight = 1, Cost = 1.49m, ProductType = type2 };
                db.Products.AddRange(new List<Product> { product1, product2, product3, product4 });
                
                Depot depot1 = new Depot();
                Depot depot2 = new Depot();
                               
                Store store1 = new Store { Name = "Перекрёстое 1", Address = "г.Могилев,просп.Пушкинский,24",Depot = depot1 };
                Store store2 = new Store {  Name = "Перекрёстое 12", Address = "г.Могилев,просп.Пушкинский,35Б",Depot = depot2};
                store1.Depot.Products.Add(product1);
                store2.Depot.Products.Add(product3);

                db.Stores.Add(store1);
                db.Stores.Add(store2);
                saver.SaveDb();
 */

            }
           
        }
    }
}
