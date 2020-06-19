using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Ball_Timer
{
    public partial class Lab4 : Form
    {
        public Lab4()
        {
            InitializeComponent();

            this.Resize += (sender, e) => this.Invalidate();
            graphics = CreateGraphics();

        }
        Graphics graphics;
        int r = 0;
        int l = 200;
        int val;

        protected override void OnPaint(PaintEventArgs e)
        {
            graphics.FillEllipse(Brushes.White, val, 520, 75, 75);
            graphics.FillEllipse(Brushes.Snow, val, 520, 75, 75);
            graphics.FillEllipse(Brushes.Black, val+27, 545, 25, 25);
            graphics.FillEllipse(Brushes.Black, val+12, 530, 15, 15);
            graphics.FillEllipse(Brushes.Black, val+50, 530, 15, 15);
            graphics.FillEllipse(Brushes.Black, val+12, 570, 15, 15);
            graphics.FillEllipse(Brushes.Black, val+50, 570, 15, 15);
            graphics.DrawEllipse(Pens.Black, val, 520, 75, 75);
            graphics.DrawEllipse(Pens.Black, val+26, 520, 25, 25);
            graphics.DrawEllipse(Pens.Black, val+27, 570, 25, 25);
            graphics.DrawEllipse(Pens.Black, val+1, 545, 25, 25);
            graphics.DrawEllipse(Pens.Black, val+50, 545, 25, 25);
            base.OnPaint(e);
        }

        private void Lab4_Load(object sender, EventArgs e)
        {
            Timer timer1 = new Timer();
            Timer timer2 = new Timer();
            timer1.Interval = 500;
            timer2.Interval = 500;
            val = 220;
            timer1.Tick += (s, eve) => {
                this.Invalidate();
                val += r;
                r += 20;
                Debug.WriteLine($"T1 * Val = {val}");
                if (val >= 560)
                {
                    r = 0;
                    timer1.Stop();
                    timer2.Start();
                }
            };
            timer2.Tick += (s, eve) => {
                this.Invalidate();
                val -= l;
                l -= 20;
                Debug.WriteLine($"T2 * Val = {val}");

                if (val <= 260)
                {
                    l = 200;
                    timer2.Stop();
                    timer1.Start();
                }
            };
            timer1.Start();
        }
    }
}
