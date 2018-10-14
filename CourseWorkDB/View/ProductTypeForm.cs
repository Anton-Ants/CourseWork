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
    public partial class ProductTypeForm : Form
    {
        ProductType ProductType = new ProductType();

        public ProductTypeForm()
        {
            InitializeComponent();
        }

        private void ProductTypeForm1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storesDBDataSet.ProductTypes". При необходимости она может быть перемещена или удалена.
            this.productTypesTableAdapter.Fill(this.storesDBDataSet.ProductTypes);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductType.Type = txtType.Text;
            using (ShopContext db = new ShopContext())
            {
                db.ProductTypes.Add(ProductType);
                db.SaveChanges();
            }
            Clear();
            PopulateDataGridView();
            MessageBox.Show("ProductType Add");
        }

        void Clear()
        {
            txtType.Text ="";
            btnAdd.Text = "Save";
            btnDelete.Enabled = false;
            ProductType.Id = 0;
        }

        void PopulateDataGridView()
        {
            using (ShopContext db = new ShopContext())
            {
                dgvProductType.DataSource = db.Products.ToList<Product>();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
