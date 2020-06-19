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
            dataContext = new DataBaseManager();
        }

        DataBaseManager dataContext;
        private void btnSave_Click(object sender, EventArgs e)
        {
            productBindingSource.EndEdit();
            try
            {
                dataContext.SaveChanges();
            }
            catch(Exception ex)
            {
                Text = ex.Message;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.TryParse(productIDLabel1.Text, out int i) ? i : 0;
            var product = dataContext.Products.Find(id);
            dataContext.Products.Remove(product);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            categoryIDComboBox.DataSource =
                dataContext.Categories.Local.ToBindingList();
            categoryIDComboBox.DisplayMember = "CategoryName";
            categoryIDComboBox.ValueMember = "CategoryID";
            categoryIDComboBox.DataBindings.Add("SelectedValue", productBindingSource, "CategoryID");

            supplierIDComboBox.DataSource =
                dataContext.Suppliers.Local.ToBindingList();
            supplierIDComboBox.DisplayMember = "CompanyName";
            supplierIDComboBox.ValueMember = "SupplierID";
            supplierIDComboBox.DataBindings.Add("SelectedValue", productBindingSource, "SupplierID");
        }
    }
}
