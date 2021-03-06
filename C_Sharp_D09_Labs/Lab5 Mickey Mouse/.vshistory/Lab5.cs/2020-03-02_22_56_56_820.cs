﻿using System;
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
            path.StartFigure();
            path.AddEllipse(100, 100, this.Width - 200, this.Height - 100);
            path.AddEllipse(0, 0, 200, 200);
            path.AddEllipse(Width - 200, 0, 200, 200);
            path.CloseFigure();
            graphics.FillPath(Brushes.White, path);
            graphics.DrawPath(Pens.Red, path);
            base.OnPaint(e);
        }
    }
}
