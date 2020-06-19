using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Mickey_Mouse
{
    public partial class Lab5 : Form
    {
        public Lab5()
        {
            InitializeComponent();

            GraphicsPath path = new GraphicsPath(FillMode.Winding);
            Graphics graphics = CreateGraphics();

            path.AddEllipse(100, 100, this.Width-200, this.Height-100);
            path.AddEllipse(0, 0, 200, 200);
            path.AddEllipse(Width-200, 0 , 200, 200);
            path.AddArc(Width / 2, 300, 50, 100, 0, 360);
            path.StartFigure();
            path.AddArc(10, 10, 100, 100, 20, 50);
            path.AddLine(20, 50, 70, 230);
            path.CloseFigure();
            //path.AddEllipse(100, 100, 700, 700);
            graphics.FillEllipse(Brushes.White, Width / 2, Height / 2, Width / 4, Height / 2);

            this.Region = new Region(path);
        }
    }
}
