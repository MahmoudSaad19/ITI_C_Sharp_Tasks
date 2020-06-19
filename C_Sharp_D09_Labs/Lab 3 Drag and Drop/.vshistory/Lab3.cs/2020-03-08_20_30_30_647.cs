using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


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
        int oldX = 50;
        int oldY = 50;

        private void Lab3_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics graphics = CreateGraphics();
            if (e.Button == MouseButtons.Left && e.X >= oldX-50 && e.X <= oldY+100) 
                if (e.Y >= oldY && e.Y <= oldY+100)
                {                    
                    oldX = e.X;
                    oldY = e.Y;
                    BackColor = Color.White;
                    graphics.Clear(Color.White);
                    graphics.FillRectangle(Brushes.OrangeRed, e.X - 50, e.Y - 50, 100, 100);
                }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                label1.Location = e.Location;
                label1.Invalidate();
            }
        }
    }
}
