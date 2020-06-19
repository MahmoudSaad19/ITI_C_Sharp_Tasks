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
            //BackColor = Color.White;
        }

        private void window_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            if (e.Button == MouseButtons.Left)
            {
                //BackColor = Color.DodgerBlue;
                
                graphics.FillRectangle(Brushes.DodgerBlue, e.X-10, e.Y-10, e.X+10, e.Y+10);

            }
            else if(e.Button == MouseButtons.Right)
            {
                graphics.FillRectangle(Brushes.White, e.X-25, e.Y-25, 50, 50);
            }

        }
    }
}
