using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Table
{
    public partial class Detailed : Form
    {
        public Detailed()
        {
            InitializeComponent();
            table = new DataTable();
            eTable = new DataTable();
            sTable = new DataTable();
            cTable = new DataTable();
        }

        DataTable table;
        DataTable eTable;
        DataTable sTable;
        DataTable cTable;
        BindingSource bindingSourceClass;

        private void Detailed_Load(object sender, EventArgs e)
        {
            bindingSourceClass = new BindingSource(dtPrds, "");

            bindingNavigator1.BindingSource = bindingSourceClass;


            lblProductID.DataBindings.Add("Text", bindingSourceClass, "ProductID");
            txtProductName.DataBindings.Add("Text", bindingSourceClass, "ProductName");
            numProductPrice.DataBindings.Add("value", bindingSourceClass, "UnitPrice");
            chkDiscontinued.DataBindings.Add("Checked", bindingSourceClass, "Discontinued");
        }
    }
}
