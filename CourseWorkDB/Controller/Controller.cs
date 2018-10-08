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
                Saver save = new Saver();
               
               
                ProductType type1 = new ProductType{ Type = "Крупы" };
                ProductType type2 = new ProductType { Type = "Напитки" };
                save.AddType(type1);
                save.AddType(type2);
                save.SaveDb();
                Product product1 = new Product { Name = "Крупа гречневая «Бабушкина кухня»", Weight = 0.7, Cost = 1.35m, ProductType = type1 };
                Product product2 = new Product { Name = "Крупа гречневая «Фермер»", Weight = 0.9, Cost = 1.09m, ProductType = type1 };
                Product product3 = new Product { Name = "Квас «Лидский» хлебный", Weight = 1.5, Cost = 1.65m, ProductType = type2 };
                Product product4 = new Product { Name = "Напиток «Pepsi»", Weight = 1, Cost = 1.49m, ProductType = type2 };
                db.Products.AddRange(new List<Product> { product1, product2, product3, product4 });
                save.SaveDb();

            }
           
        }
    }
}
