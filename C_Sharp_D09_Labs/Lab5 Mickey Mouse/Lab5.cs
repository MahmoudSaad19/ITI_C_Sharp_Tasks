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
            GraphicsPath path2 = new GraphicsPath();
            GraphicsPath path3 = new GraphicsPath();
            path2.StartFigure();
            path2.AddEllipse(120, 150, this.Width - 250, this.Height - 130); // white face
            //path2.AddEllipse(120, 150, this.Width - 250, this.Height - 130); // white face
            //path2.AddEllipse(120, 150, this.Width - 250, this.Height - 130); // white face
            path2.AddEllipse(270, 250, 40, 50); // left eye
            path2.AddEllipse(340, 250, 40, 50); // right eye
            path2.AddEllipse(274, 300, 100, 60); //nose
            path2.AddBezier(250, 400, 300, 450, 350, 450, 400, 400); //mouth
            path2.CloseFigure();

            path3.AddEllipse(260, 180, 60, 120); // left eye
            path3.AddEllipse(330, 180, 60, 120); // right eye

            graphics.FillPath(Brushes.Black, path3);
            graphics.DrawPath(Pens.Black, path2);

            graphics.FillPath(Brushes.White, path2);
            graphics.DrawPath(new Pen(Color.Black,3), path3);

            base.OnPaint(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool ReleaseCapture();
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
