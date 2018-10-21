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
    public partial class GoodsSoldForm : Form
    {
        Store store = new Store();
        Product product = new Product();
        Depot depot = new Depot();
        GoodsSold goodsSold = new GoodsSold();

        public GoodsSoldForm()
        {
            InitializeComponent();
        }

        private void GoodsSoldForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storesDBDataSet.Stores". При необходимости она может быть перемещена или удалена.
            this.storesTableAdapter.Fill(this.storesDBDataSet.Stores);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storesDBDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.storesDBDataSet.Products);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        void PopulateDataGridView()
        {
            using (ShopContext db = new ShopContext())
            {
                dgvGoodsSold.DataSource = db.GoodsSolds.ToList<GoodsSold>();
            }
        }

        private void btnSold_Click(object sender, EventArgs e)
        {
            using (ShopContext db = new ShopContext())
            {
                goodsSold.Store = db.Stores.FirstOrDefault(x => x.Id == (int)comboBoxStore.SelectedValue);
                

                product = db.Products.FirstOrDefault(x => x.Id == (int)comboBoxProduct.SelectedValue);
                store = db.Stores.FirstOrDefault(x => x.Id == (int)comboBoxStore.SelectedValue);
                //goodsSold = product.Quantity - Convert.ToInt32(txtHowMuch.Text);
            }
        }
    }
}
