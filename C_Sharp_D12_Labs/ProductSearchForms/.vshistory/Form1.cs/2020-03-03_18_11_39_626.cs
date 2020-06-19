using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductSearchForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataBaseManager dataContext = new DataBaseManager();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var products = (from p in dataContext.Products
                            select p).ToList();
            var res = products.Where(p => p.ProductName.Contains(textBox1.Text));
            dataGridView1.DataSource = res.ToList();
        }

        private void btnAdvancedSearch_Click(object sender, EventArgs e)
        {
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            var products = (from p in dataContext.Products
                            select p).ToList();
            var res = products.Where(p => p.ProductID == int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString())).ToList();
            form2.productBindingSource.DataSource = res;
        }
    }
}
