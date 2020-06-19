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
        BindingSource bindingSourcePrds;

        private void Detailed_Load(object sender, EventArgs e)
        {
            bindingSourcePrds = new BindingSource(dtPrds, "");

            bindingNavigator1.BindingSource = bindingSourcePrds;

            OrderIDLabel.DataBindings.Add("Text",)
            lblProductID.DataBindings.Add("Text", bindingSourcePrds, "ProductID");
            txtProductName.DataBindings.Add("Text", bindingSourcePrds, "ProductName");
            numProductPrice.DataBindings.Add("value", bindingSourcePrds, "UnitPrice");
            chkDiscontinued.DataBindings.Add("Checked", bindingSourcePrds, "Discontinued");
        }
    }
}
