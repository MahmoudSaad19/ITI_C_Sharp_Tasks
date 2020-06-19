using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Grid_Table
{
    public partial class ProductGrid : Form
    {
        public ProductGrid()
        {
            InitializeComponent();
        }

        BindingSource bindingSourceProducts;

        private void ProductGrid_Load(object sender, EventArgs e)
        {
            try
            {
                var products = ProductsManager.SelectAllProducts();
                bindingSourceProducts = new BindingSource(products, "");

                dataGridView1.DataSource = bindingSourceProducts;
            }
            catch
            {

            }
        }
    }
}
