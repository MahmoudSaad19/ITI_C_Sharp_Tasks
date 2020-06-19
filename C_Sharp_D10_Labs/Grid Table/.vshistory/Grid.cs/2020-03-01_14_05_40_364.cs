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
        }

        DataTable table;

        private void Grid_Load(object sender, EventArgs e)
        {
            OrdersAdapter1.Fill(table);
            dataGridView1.DataSource = table;

            DataGridViewComboBoxColumn ECB = new DataGridViewComboBoxColumn();
            ECB.HeaderText = "Employee Name";
            ECB.DataSource = EAdapter2;
            ECB.DisplayMember = "CompanyName";
            ECB.ValueMember = "EID";
            ECB.DataPropertyName = "EmployeeID"; ///from Products Datatable

            dataGridView1.Columns.Add(ECB);

            //dataGridView1.Columns["EmployeeID"].Visible = false;
        }
    }
}
