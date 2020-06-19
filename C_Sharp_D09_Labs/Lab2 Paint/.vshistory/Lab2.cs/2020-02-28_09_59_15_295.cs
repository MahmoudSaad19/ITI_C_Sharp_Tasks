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

        protected override void OnMouseMove(MouseEventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            
            if (e.Button == MouseButtons.Left)
            {
                graphics.FillRectangle(Brushes.DodgerBlue, e.X - 5, e.Y - 5, 10, 10);
            }
            else if (e.Button == MouseButtons.Right)
            {
                graphics.FillRectangle(Brushes.White, e.X - 15, e.Y - 15, 30, 30);
            }
            base.OnMouseMove(e);
        }
               
    }
}
