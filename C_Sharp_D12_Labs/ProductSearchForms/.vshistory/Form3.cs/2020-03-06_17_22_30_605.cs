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
            operatorComparsion2.Add(">");
            operatorComparsion2.Add("<");
            operatorComparsion2.Add("=");
            dataContext.Products.Load();
            Selectedproduct = dataContext.Products;
            
        }
        List<string> operatorComparsion = new List<string>();
        List<string> operatorComparsion2 = new List<string>();
        DataBaseManager dataContext = new DataBaseManager();
        IQueryable<Product> Selectedproduct;
        private void Form3_Load(object sender, EventArgs e)
        {
            dataContext.Categories.Load();
            dataContext.Suppliers.Load();
            comboBoxUnitPrice.DataSource = operatorComparsion;
            comboBoxunitsInStock.DataSource = operatorComparsion2;
            categoryComboBox.DataSource = dataContext.Categories.Select(c => c.CategoryName).ToList();
            supplierComboBox.DataSource = dataContext.Suppliers.Select(s => s.CompanyName).ToList();
        }

        private void btnAdvSearch_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (!(ckBoxCategory.Checked || ckBoxDiscontinued.Checked || ckBoxProductName.Checked || ckBoxSupplier.Checked || ckBoxUnitPrice.Checked || ckBoxUnitsInStock.Checked))
                form2.productBindingSource.DataSource =
                    dataContext.Products.Where(p => 1 == 2).ToList();
            else
                form2.productBindingSource.DataSource = Selectedproduct.ToList();
            form2.Show();
            this.Hide();
        }

        private void ckBoxDiscontinued_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxDiscontinued.Checked)
             Selectedproduct = Selectedproduct.Where(p => p.Discontinued == discontinuedCheckBox.Checked);
        }

        private void ckBoxProductName_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxProductName.Checked)
                Selectedproduct = Selectedproduct.Where(p => p.ProductName == productNameTextBox.Text);
        }

        private void ckBoxUnitPrice_CheckedChanged(object sender, EventArgs e)
        {
            string op = comboBoxUnitPrice.SelectedItem.ToString();
            if (ckBoxUnitPrice.Checked)            
                switch (op)
                {
                    case "=":
                        Selectedproduct = Selectedproduct.Where(p => p.UnitPrice == unitPriceNumericUpDown.Value);
                        break;
                    case "<":
                        Selectedproduct = Selectedproduct.Where(p => p.UnitPrice < unitPriceNumericUpDown.Value);
                        break;
                    default:
                        Selectedproduct = Selectedproduct.Where(p => p.UnitPrice > unitPriceNumericUpDown.Value);
                        break;
                }
                            
        }

        private void ckBoxUnitsInStock_CheckedChanged(object sender, EventArgs e)
        {
            string op = comboBoxunitsInStock.SelectedItem.ToString();
            if (ckBoxUnitsInStock.Checked)
                switch (op)
                {
                    case "=":
                        Selectedproduct = Selectedproduct.Where(p => p.UnitsInStock == unitsInStockNumericUpDown.Value);
                        break;
                    case "<":
                        Selectedproduct = Selectedproduct.Where(p => p.UnitsInStock < unitsInStockNumericUpDown.Value);
                        break;
                    default:
                        Selectedproduct = Selectedproduct.Where(p => p.UnitsInStock > unitsInStockNumericUpDown.Value);
                        break;
                }
        }

        private void ckBoxCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxCategory.Checked)
                Selectedproduct = Selectedproduct.Where(p => p.Category.CategoryName == categoryComboBox.SelectedItem.ToString());
        }

        private void ckBoxSupplier_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxSupplier.Checked)
                Selectedproduct = Selectedproduct.Where(p => p.Supplier.CompanyName == supplierComboBox.SelectedItem.ToString());
        }
    }
}
