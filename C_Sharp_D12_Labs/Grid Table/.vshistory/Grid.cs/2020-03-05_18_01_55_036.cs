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

namespace Grid_Table
{
    public partial class Grid : Form
    {
        public Grid()
        {
            InitializeComponent();
        }
        DataBaseManager dataContext = new DataBaseManager();
        private void Grid_Load(object sender, EventArgs e)
        {
            dataContext.Products.Load();
            productBindingSource.DataSource =
                dataContext.Products.Local.ToBindingList();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            productBindingSource.EndEdit();
            dataContext.SaveChanges();
        }
    }
}
