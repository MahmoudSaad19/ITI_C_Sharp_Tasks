﻿using System;
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
        }

        DataTable table;
        DataTable eTable;
        DataTable sTable;

        private void Grid_Load(object sender, EventArgs e)
        {
            OrdersAdapter1.Fill(table);
            EAdapter2.Fill(eTable);
            dataGridView1.DataSource = table;

            DataGridViewComboBoxColumn ECB = new DataGridViewComboBoxColumn();
            ECB.HeaderText = "Employee Name";
            ECB.DataSource = eTable;
            ECB.DisplayMember = "Full Name";
            ECB.ValueMember = "EID";        ///from Employee Datatable
            ECB.DataPropertyName = "EmployeeID"; ///from Orders Datatable

            DataGridViewComboBoxColumn SCB = new DataGridViewComboBoxColumn();
            SCB.HeaderText = "Shipper Name";
            SCB.DataSource = eTable;
            SCB.DisplayMember = "CompanyName";
            SCB.ValueMember = "ShipperID"; ///from Shippers Datatable
            SCB.DataPropertyName = "ShipVia"; ///from Orders Datatable
            dataGridView1.Columns.Add(ECB);

            //dataGridView1.Columns["EmployeeID"].Visible = false;
        }

    }
}
