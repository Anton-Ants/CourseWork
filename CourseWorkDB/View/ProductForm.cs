using CourseWorkDB.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
        ProductType type = new ProductType();
        Store store = new Store();
        Depot depot = new Depot();
        public ProductForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storesDBDataSet.Stores". При необходимости она может быть перемещена или удалена.
            this.storesTableAdapter.Fill(this.storesDBDataSet.Stores);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storesDBDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.storesDBDataSet.Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storesDBDataSet.ProductTypes". При необходимости она может быть перемещена или удалена.
            this.productTypesTableAdapter.Fill(this.storesDBDataSet.ProductTypes);
            Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }

        void Clear()
        {
            txtName.Text = txtWeight.Text = txtCost.Text = txtQuantity.Text = "";
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

            using (ShopContext db = new ShopContext()) 
            {
            
                product.Name = txtName.Text.Trim();
                product.Weight = Convert.ToDouble(txtWeight.Text);
                product.Cost = Convert.ToDecimal(txtCost.Text);
                product.Quantity = Convert.ToInt32(txtQuantity.Text);
                product.ProductType = db.ProductTypes.FirstOrDefault(x => x.Id == (int)comboBoxType.SelectedValue);

                if (product.Id == 0)
                    db.Products.Add(product);
                else
                    db.Entry(product).State = EntityState.Modified;
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

        private void dgvProduct_DoubleClick(object sender, EventArgs e)
        {
            if (dgvProduct.CurrentRow.Index != -1)
            {
                product.Id = Convert.ToInt32(dgvProduct.CurrentRow.Cells["Id"].Value);
                using (ShopContext db = new ShopContext())
                {
                    product = db.Products.Where(x => x.Id == product.Id).FirstOrDefault();
                    txtName.Text = product.Name;
                    txtWeight.Text = Convert.ToString(product.Weight);
                    txtCost.Text = Convert.ToString(product.Cost);
                    txtQuantity.Text = Convert.ToString(product.Quantity);
                }
                btnAdd.Text = "Update";
                btnDelete.Enabled = true;

                labelStore.Visible = true;
                btnAddInStore.Visible = true;
                comboBoxStore.Visible = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            using(ShopContext db = new ShopContext())
                {
                    var entry = db.Entry(product);
                    if (entry.State == EntityState.Detached)
                        db.Products.Attach(product);
                    db.Products.Remove(product);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                }

        }

        private void btnAddInStore_Click(object sender, EventArgs e)
        {
          /*  using (ShopContext db = new ShopContext())
            {
                product.Name = txtName.Text.Trim();
                product.Weight = Convert.ToDouble(txtWeight.Text);
                product.Cost = Convert.ToDecimal(txtCost.Text);
                product.ProductType = db.ProductTypes.FirstOrDefault(x => x.Id == (int)comboBoxType.SelectedValue);
                store = db.Stores.FirstOrDefault(x => x.Id == (int)comboBoxStore.SelectedValue);
                store.Depot = db.Depots.FirstOrDefault(x => x.Id == (int)comboBoxStore.SelectedValue);
                store.Depot.Products.Add(product);
                db.SaveChanges();
            }*/
            

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
