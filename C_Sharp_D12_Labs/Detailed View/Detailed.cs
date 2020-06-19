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

namespace Detailed_View
{
    public partial class Detailed : Form
    {
        public Detailed()
        {
            InitializeComponent();
        }

        DataBaseManager dataContext = new DataBaseManager();

        private void Detailed_Load(object sender, EventArgs e)
        {
            
            dataContext.Products.Load();
            productBindingSource.DataSource =
            dataContext.Products.Local.ToBindingList();


        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
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
    }
}
