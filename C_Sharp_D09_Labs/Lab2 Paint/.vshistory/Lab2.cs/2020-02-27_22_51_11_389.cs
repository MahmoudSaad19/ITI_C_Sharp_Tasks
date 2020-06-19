using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Paint
{
    public partial class window : Form
    {
        public window()
        {
            InitializeComponent();
        }

        private void window_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BackColor = Color.DodgerBlue;

            }
            else if(e.Button == MouseButtons.Right)
            {
                BackColor = Color.White;
            }

        }
    }
}
