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
            Application.Run(new Form1());

            using (ShopContext db = new ShopContext())
            {
                Saver save = new Saver(db);
               
               
                ProductType type1 = new ProductType{ Type = "Крупы" };
                ProductType type2 = new ProductType { Type = "Напитки" };
                save.AddType(type1);
                save.AddType(type2);

                Product product1 = new Product { Name = "Крупа гречневая «Бабушкина кухня»", Weight = 0.7, Cost = 1.35m, ProductType = type1  };
                Product product2 = new Product { Name = "Крупа гречневая «Фермер»", Weight = 0.9, Cost = 1.09m, ProductType = type1 };
                Product product3 = new Product { Name = "Квас «Лидский» хлебный", Weight = 1.5, Cost = 1.65m, ProductType = type2};
                Product product4 = new Product { Name = "Напиток «Pepsi»", Weight = 1, Cost = 1.49m, ProductType = type2 };
                db.Products.AddRange(new List<Product> { product1, product2, product3, product4 });
                save.SaveDb();

                Depot depot1 = new Depot();
                depot1.Products.Add(product1);
                depot1.Products.Add(product2);

                Depot depot2 = new Depot();
                depot2.Products.Add(product3);

                db.Depots.Add(depot1);
                db.Depots.Add(depot2);
                save.SaveDb();
                Store store1 = new Store {Id =depot1.Id, Name = "Перекрёстое 1", Address = "г.Могилев,просп.Пушкинский,24" };
                Store store2 = new Store { Id = depot2.Id, Name = "Перекрёстое 12", Address = "г.Могилев,просп.Пушкинский,35Б" };
                db.Stores.Add(store1);
                db.Stores.Add(store2);
                save.SaveDb();
 

            }
           
        }
    }
}
