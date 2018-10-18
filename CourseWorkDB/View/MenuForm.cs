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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductForm prdForm = new ProductForm();
            prdForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductTypeForm typeForm = new ProductTypeForm();
            typeForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StoresForm storesForm = new StoresForm();
            storesForm.Show();
        }

        private void btnGoodsSold_Click(object sender, EventArgs e)
        {
            GoodsSoldForm GoodsSoldForm = new GoodsSoldForm();
            GoodsSoldForm.Show();
        }
    }
}
