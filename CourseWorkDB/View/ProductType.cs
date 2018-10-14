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
using CourseWorkDB.StoresDBDataSetTableAdapters;

namespace CourseWorkDB.View
{
    public partial class ProductType : Form
    {
        ProductType type1 = new ProductType();

        public ProductType()
        {
            InitializeComponent();
        }

        private void ProductType_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storesDBDataSet.ProductTypes". При необходимости она может быть перемещена или удалена.
            this.productTypesTableAdapter.Fill(this.storesDBDataSet.ProductTypes);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            using (ShopContext db = new ShopContext())
            {
                
                db.ProductTypes.Add();
                db.SaveChanges();
            }
            Clear(); 
            PopulateDataGridView();
        }

        void Clear()
        {
            txtType.Text = "";
            btnAdd.Text = "Save";
            
        }

        void PopulateDataGridView()
        {
            using (ShopContext db = new ShopContext())
            {
                dgvProductType.DataSource = db.Products.ToList<Product>();
            }
        }

    }
}
