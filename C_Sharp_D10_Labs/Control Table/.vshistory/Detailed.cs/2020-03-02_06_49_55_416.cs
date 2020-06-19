using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            EAdapter2.Fill(eTable);
            SAdapter1.Fill(sTable);
            CAdapter1.Fill(cTable);
            bindingNavigator1.BindingSource = bindingSourceClass;

            comboBoxE.Items.Add(eTable.Rows[1].ItemArray[1]);
            comboBoxE.DataSource = eTable;
            comboBoxE.DisplayMember = "Full Name";
            comboBoxE.ValueMember = "EID";
            comboBoxE.DataBindings.Add("SelectedItem", bindingSourceClass, "EmployeeID");
            foreach (var item in eTable.Rows[1].ItemArray)
            {
                Debug.WriteLine(item);
            }

            OrderIDLabel.DataBindings.Add("Text", bindingSourceClass, "OrderID");
            txtShipName.DataBindings.Add("Text", bindingSourceClass, "ShipName");
            FreightnumericUpDown.DataBindings.Add("value", bindingSourceClass, "Freight");
            txtShipCity.DataBindings.Add("Text", bindingSourceClass, "ShipCity");
            dateTimePicker1.DataBindings.Add("value", bindingSourceClass, "OrderDate");

            comboBoxS.DataSource = sTable;
            comboBoxS.DisplayMember = "CompanyName";
            comboBoxS.ValueMember = "ShipperID";
            comboBoxS.DataBindings.Add("SelectedItem", bindingSourceClass, "ShipperVia");





        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSourceClass.EndEdit();
                OrdersAdapter1.Update(table);
            }
            catch (Exception e1)
            {
                Text = "Error     " + e1.Message;
            }
        }

       
    }
}
