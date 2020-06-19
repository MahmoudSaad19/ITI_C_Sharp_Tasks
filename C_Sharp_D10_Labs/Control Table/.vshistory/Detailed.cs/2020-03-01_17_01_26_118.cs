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
            bindingSourceClass = new BindingSource(table, "");
            OrdersAdapter1.Fill(table);
            OrdersAdapter1.Fill(table);
            EAdapter2.Fill(eTable);
            SAdapter1.Fill(sTable);
            CAdapter1.Fill(cTable);
            bindingNavigator1.BindingSource = bindingSourceClass;


            OrderIDLabel.DataBindings.Add("Text", bindingSourceClass, "OrderID");
            txtShipName.DataBindings.Add("Text", bindingSourceClass, "ShipName");
            FreightnumericUpDown.DataBindings.Add("value", bindingSourceClass, "Freight");
            txtShipCity.DataBindings.Add("Text", bindingSourceClass, "ShipCity");
            dateTimePicker1.DataBindings.Add("value", bindingSourceClass, "OrderDate");
            comboBoxE.DataBindings.Add("Items", bindingSourceClass, "EmployeeID");
            //ComboBox ECB = new DataGridViewComboBoxColumn();
            //ECB.HeaderText = "Employee Name";
            //ECB.DataSource = eTable;
            //ECB.DisplayMember = "Full Name";
            //ECB.ValueMember = "EID";        ///from Employee Datatable
            //ECB.DataPropertyName = "EmployeeID"; ///from Orders Datatable


        }
    }
}
