using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            table = new DataTable();
            eTable = new DataTable();
            sTable = new DataTable();
            cTable = new DataTable();
        }

        DataTable table;
        DataTable eTable;
        DataTable sTable;
        DataTable cTable;

        private void Grid_Load(object sender, EventArgs e)
        {
            OrdersAdapter1.Fill(table);
            EAdapter2.Fill(eTable);
            SAdapter1.Fill(sTable);
            CAdapter1.Fill(cTable);
            dataGridView1.DataSource = table;

            DataGridViewComboBoxColumn ECB = new DataGridViewComboBoxColumn();
            ECB.HeaderText = "Employee Name";
            ECB.DataSource = eTable;
            ECB.DisplayMember = "Full Name";
            ECB.ValueMember = "EID";        ///from Employee Datatable
            ECB.DataPropertyName = "EmployeeID"; ///from Orders Datatable

            DataGridViewComboBoxColumn SCB = new DataGridViewComboBoxColumn();
            SCB.HeaderText = "Shipper Name";
            SCB.DataSource = sTable;
            SCB.DisplayMember = "CompanyName";
            SCB.ValueMember = "ShipperID"; ///from Shippers Datatable
            SCB.DataPropertyName = "ShipVia"; ///from Orders Datatable

            DataGridViewComboBoxColumn CCB = new DataGridViewComboBoxColumn();
            CCB.HeaderText = "Customer Name";
            CCB.DataSource = cTable;
            CCB.DisplayMember = "ContactName";
            CCB.ValueMember = "CID"; ///from Customer Datatable
            CCB.DataPropertyName = "CustomerID"; ///from Orders Datatable

            dataGridView1.Columns.Add(ECB);
            dataGridView1.Columns.Add(SCB);
            dataGridView1.Columns.Add(CCB);

            dataGridView1.Columns["EmployeeID"].Visible = false;
            dataGridView1.Columns["ShipVia"].Visible = false;
            dataGridView1.Columns["OrderID"].Visible = false;
            dataGridView1.Columns["CustomerID"].Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            OrdersAdapter1.Update(table);

        }
    }
}
