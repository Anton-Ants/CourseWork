using CourseWorkDB.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkDB.View
{
    
    public partial class AddProductInStoreForm : Form
    {
        Product product = new Product();
        Store store = new Store();
        Depot depot = new Depot();
        ProductType type = new ProductType();
        int index;
        public AddProductInStoreForm()
        {
            InitializeComponent();
        }

        private void AddProductInStoreForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storesDBDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.storesDBDataSet.Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storesDBDataSet.Stores". При необходимости она может быть перемещена или удалена.
            this.storesTableAdapter.Fill(this.storesDBDataSet.Stores);
            

        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using(ShopContext db = new ShopContext())
            {
                product = db.Products.FirstOrDefault(x => x.Id == (int)comboBoxProduct.SelectedValue);
                store = db.Stores.FirstOrDefault(x => x.Id == (int)comboBoxStore.SelectedValue);
                store.Depot = db.Depots.FirstOrDefault(x => x.Id == (int)comboBoxStore.SelectedValue);
                store.Depot.Products.Add(product);
                db.SaveChanges();
                MessageBox.Show("Product Add");
            }
        }

        private void comboBoxStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = comboBoxStore.FindString(comboBoxStore.Text);
        }
    }
}
