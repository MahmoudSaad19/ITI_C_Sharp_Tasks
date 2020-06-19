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
        BindingSource bindingWrapperClass;

        private void Detailed_Load(object sender, EventArgs e)
        {
            bindingWrapperClass = new BindingSource(dtPrds, "");

            bindingNavigator1.BindingSource = bindingWrapperClass;

            OrderIDLabel.DataBindings.Add("Text",)
            lblProductID.DataBindings.Add("Text", bindingWrapperClass, "ProductID");
            txtProductName.DataBindings.Add("Text", bindingWrapperClass, "ProductName");
            numProductPrice.DataBindings.Add("value", bindingWrapperClass, "UnitPrice");
            chkDiscontinued.DataBindings.Add("Checked", bindingWrapperClass, "Discontinued");
        }
    }
}
