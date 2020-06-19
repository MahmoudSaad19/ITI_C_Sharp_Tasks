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
            Point point = new Point(100, 100);
            Graphics graphics = CreateGraphics();
            if (e.Location == point)
                graphics.FillRectangle(Brushes.AliceBlue, e.X - 50, e.Y - 50, 100, 100);
        }
    }
}
