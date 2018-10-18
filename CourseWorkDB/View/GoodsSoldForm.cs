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
    }
}
