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
        Graphics graphics;
        GraphicsPath path;
        public Lab5()
        {
            InitializeComponent();

             path = new GraphicsPath(FillMode.Winding);
             graphics = CreateGraphics();

            path.AddEllipse(100, 100, this.Width-200, this.Height-100);
            path.AddEllipse(0, 0, 200, 200);
            path.AddEllipse(Width-200, 0 , 200, 200);          

            this.Region = new Region(path);

            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath path2 = new GraphicsPath();
            GraphicsPath path3 = new GraphicsPath();
            path2.StartFigure();
            path2.AddEllipse(120, 150, this.Width - 250, this.Height - 130); // white face
            path2.AddEllipse(220, 200, 60, 120); // left eye
            path2.AddEllipse(370, 200, 60, 120); // right eye
            path2.AddEllipse(270, 300, 110, 70); //nose
            path2.AddBezier(250, 400, 300, 450, 350, 450, 400, 400); //mouth
            path2.CloseFigure();

            path3.AddEllipse(220, 200, 60, 120); // left eye
            path3.AddEllipse(370, 200, 60, 120); // right eye

            graphics.FillPath(Brushes.White, path3);

            graphics.DrawArc(Pens.OrangeRed, 200, 350, 200, 30, 0, -3.14f);
            //graphics.DrawPath(Pens.Red, path3);
            graphics.FillPath(Brushes.White, path2);
            //graphics.DrawPath(Pens.Red, path2);
            base.OnPaint(e);
        }
    }
}
