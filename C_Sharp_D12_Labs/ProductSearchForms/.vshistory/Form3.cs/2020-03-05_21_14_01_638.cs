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

namespace ProductSearchForms
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            operatorComparsion.Add(">");
            operatorComparsion.Add("<");
            operatorComparsion.Add("=");
        }
        List<string> operatorComparsion = new List<string>();
        DataBaseManager dataContext = new DataBaseManager();
        private void Form3_Load(object sender, EventArgs e)
        {
            dataContext.Categories.Load();
            dataContext.Suppliers.Load();
            comboBoxUnitPrice.DataSource = operatorComparsion;
            comboBoxunitsInStock.DataSource = operatorComparsion;
            categoryComboBox.DataSource = dataContext.Categories.Select(c => c.CategoryName).ToList();
            supplierComboBox.DataSource = dataContext.Suppliers.Select(s => s.CompanyName).ToList();
        }

        private void btnAdvSearch_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.productNameTextBox.Visible = ckBoxProductName.Checked;
            form2..Visible = ckBoxProductName.Checked;
            form2.Show();
        }
    }
}
