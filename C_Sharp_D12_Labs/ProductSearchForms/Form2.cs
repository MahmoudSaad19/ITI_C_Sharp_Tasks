using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductSearchForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            productBindingSource.EndEdit();
            try
            {
                Form1.dataContext.SaveChanges();
            }
            catch(Exception ex)
            {
                Text = ex.Message;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.TryParse(productIDLabel1.Text, out int i) ? i : 0;
            var product = Form1.dataContext.Products.Find(id);
            Form1.dataContext.Products.Remove(product);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            categoryIDComboBox.DataSource =
                Form1.dataContext.Categories.Local.ToBindingList();
            categoryIDComboBox.DisplayMember = "CategoryName";
            categoryIDComboBox.ValueMember = "CategoryID";
            categoryIDComboBox.DataBindings.Add("SelectedValue", productBindingSource, "CategoryID");

            supplierIDComboBox.DataSource =
                Form1.dataContext.Suppliers.Local.ToBindingList();
            supplierIDComboBox.DisplayMember = "CompanyName";
            supplierIDComboBox.ValueMember = "SupplierID";
            supplierIDComboBox.DataBindings.Add("SelectedValue", productBindingSource, "SupplierID");
        }

        private void categoryIDNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int CatID = int.Parse(categoryIDNumericUpDown.Value.ToString());
            categoryIDComboBox.SelectedValue = CatID;
        }

        private void supplierIDNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int SID = int.Parse(supplierIDNumericUpDown.Value.ToString());
            supplierIDComboBox.SelectedValue = SID;
        }
    }
}
