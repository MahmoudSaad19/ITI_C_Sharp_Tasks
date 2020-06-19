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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dataContextManager = new DataBaseManager();
        }

        DataBaseManager dataContextManager;
        private void btnSave_Click(object sender, EventArgs e)
        {
            productBindingSource.EndEdit();
            try
            {
                dataContextManager.SaveChanges();
            }
            catch(Exception ex)
            {
                Text = ex.Message;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(productIDLabel1.Text);
            var product = dataContextManager.Products.Find(id);
            dataContextManager.Products.Remove(product);
        }
    }
}
