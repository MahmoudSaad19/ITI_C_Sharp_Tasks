using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Lab1 : Form
    {
        public Lab1()
        {
            InitializeComponent();
            btnClose.Click += (s,e) => this.Close();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {

        }
    }
}
