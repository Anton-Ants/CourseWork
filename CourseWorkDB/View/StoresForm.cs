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

namespace CourseWorkDB.View
{
    public partial class StoresForm : Form
    {
        Store store = new Store();
        Depot depot = new Depot();
        public StoresForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void StoresForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storesDBDataSet.Stores". При необходимости она может быть перемещена или удалена.
           this.storesTableAdapter.Fill(this.storesDBDataSet.Stores);

        }


        void PopulateDataGridView()
        {
            using (ShopContext db = new ShopContext())
            {
                dgvStore.DataSource = db.Stores.ToList<Store>();
            }
        }

        void Clear()
        {
            txtName.Text = txtAddress.Text ="";
            btnAdd.Text = "Save";
            btnDelete.Enabled = false;
            store.Id = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (ShopContext db = new ShopContext())
            {

                store.Name = txtName.Text.Trim();
                store.Address = txtAddress.Text.Trim();
                store.Depot = depot;
               
                if (store.Id == 0)
                    db.Stores.Add(store);
                else
                    db.Entry(store).State = EntityState.Modified;
                db.SaveChanges();

            }
            Clear();
            PopulateDataGridView();
            MessageBox.Show("Store Add");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record?","EF CRUD Operation",MessageBoxButtons.YesNo) == DialogResult.Yes)
            using (ShopContext db = new ShopContext())
                {
                    var entry = db.Entry(store);
                    if (entry.State == EntityState.Detached)
                        db.Stores.Attach(store);
 
                    db.Stores.Remove(store);                  
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();

                }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }

        private void dgvStore_DoubleClick(object sender, EventArgs e)
        {
            store.Id = Convert.ToInt32(dgvStore.CurrentRow.Cells["Id"].Value);
            using (ShopContext db = new ShopContext())
            {
                store = db.Stores.Where(x => x.Id == store.Id).FirstOrDefault();
                txtName.Text = store.Name;
                txtAddress.Text = store.Address;
            }
            btnAdd.Text = "Update";
            btnDelete.Enabled = true;
            
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductInStoreForm AddProductInStoreForm = new AddProductInStoreForm();
            AddProductInStoreForm.Show();
        }
    }
}
