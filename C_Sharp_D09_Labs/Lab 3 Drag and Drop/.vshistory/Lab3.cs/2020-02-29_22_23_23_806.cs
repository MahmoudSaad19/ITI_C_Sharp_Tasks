using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3_Drag_and_Drop
{
    public partial class Lab3 : Form
    {
        public Lab3()
        {
            InitializeComponent();

            this.Resize += (sender, e) => this.Invalidate();

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.OrangeRed, 50, 50, 100, 100);

            base.OnPaint(e);
        }

        private void Lab3_MouseClick(object sender, MouseEventArgs e)
        {

            //Graphics graphics = CreateGraphics();
            //if (e.X >= 50 && e.X <= 150)
            //    if (e.Y >= 50 && e.Y <= 150)
            //        graphics.FillRectangle(Brushes.AliceBlue, e.X - 50, e.Y - 50, 100, 100);
        }
        Int16 oldX = 50;
        Int16 oldY = 50;

        private void Lab3_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics graphics = CreateGraphics();
            if (e.Button == MouseButtons.Left && e.X >= 50 && e.X <= 150)
                if (e.Y >= 50 && e.Y <= 150)
                {
                    BackColor = Color.White;
                    graphics.FillRectangle(Brushes.OrangeRed, e.X - 50, e.Y - 50, 100, 100);

                }
        }
    }
}
