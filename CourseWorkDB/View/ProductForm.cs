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

namespace CourseWorkDB
{
    public partial class ProductForm : Form
    {

        Product product = new Product();
       // ProductType type = new ProductType();
        public ProductForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storesDBDataSet.ProductTypes". При необходимости она может быть перемещена или удалена.
            this.productTypesTableAdapter.Fill(this.storesDBDataSet.ProductTypes);
            Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // ProductType type = new ProductType {Type = comboBoxType.Text};
           // object type = comboBoxType.SelectedValue;
           
        }

        void Clear()
        {
            txtName.Text = txtWeight.Text = txtCost.Text = "";
            btnAdd.Text = "Save";
            btnDelete.Enabled = false;
            product.Id = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }
        
        private void btnAdd_Click(object sender, EventArgs e) 
        {
            
            product.Name = txtName.Text.Trim();
            product.Weight = Convert.ToDouble(txtWeight.Text);
            product.Cost = Convert.ToDecimal(txtCost.Text);
           // product.ProductType = type;


            using (ShopContext db = new ShopContext())
            {
                db.Products.Add(product);
                db.SaveChanges();
            }
            Clear();
            PopulateDataGridView();
            MessageBox.Show("Product Add");
        }

        void PopulateDataGridView()
        {
            using (ShopContext db = new ShopContext())
            {
                dgvProduct.DataSource = db.Products.ToList<Product>();
            }
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
