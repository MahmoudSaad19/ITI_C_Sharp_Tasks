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
            BackColor = Color.White;
        }

        protected override void OnMouseHover(EventArgs e)
        {
            
            BackColor = Color.OrangeRed;
            base.OnMouseHover(e);
        }

        private void window_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
                graphics.FillRectangle(Brushes.DodgerBlue, e.X - 10, e.Y - 10, 20, 20);
            if (e.Button == MouseButtons.Left)
            {
                //protected override void OnMouseHover(EventArgs e)
                //    {
                base.OnMouseHover(e);
                //    }
            }
            else if(e.Button == MouseButtons.Right)
            {
                graphics.FillRectangle(Brushes.White, e.X - 25, e.Y - 25, 50, 50);
            }

        }
       
    }
}
