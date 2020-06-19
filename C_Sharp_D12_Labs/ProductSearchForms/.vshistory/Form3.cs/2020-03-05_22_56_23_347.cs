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
            Selectedproduct = dataContext.Products;
            
        }
        List<string> operatorComparsion = new List<string>();
        DataBaseManager dataContext = new DataBaseManager();
        IQueryable<Product> Selectedproduct;
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
            int selectedCategoryID = 1;
            int SelectedSupplierID = 1;
            Form2 form2 = new Form2();
            dataContext.Products.Load();
            var selectedCategory = dataContext.Categories.Where(c => c.CategoryName == categoryComboBox.SelectedItem.ToString());
            var SelectedSupplier = dataContext.Suppliers.Where(s =>
              s.CompanyName == supplierComboBox.SelectedItem.ToString());

            if (ckBoxCategory.Checked)
                selectedCategoryID = selectedCategory.Select(c => c.CategoryID).FirstOrDefault();
            //if(ckBoxSupplier.Checked)
                

            form2.productBindingSource.DataSource =
                Selectedproduct.ToList();
            form2.Show();
        }

        private void ckBoxDiscontinued_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxDiscontinued.Checked)
             Selectedproduct = Selectedproduct.Where(p => p.Discontinued == discontinuedCheckBox.Checked);
        }
    }
}
