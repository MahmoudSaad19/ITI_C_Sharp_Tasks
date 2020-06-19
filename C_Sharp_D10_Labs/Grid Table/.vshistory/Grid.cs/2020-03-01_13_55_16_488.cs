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
            sqlDataAdapter1.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
