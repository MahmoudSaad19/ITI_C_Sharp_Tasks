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
            graphics.FillEllipse(Brushes.SaddleBrown, val, 520, 70, 70);
            base.OnPaint(e);
        }

        private void Lab4_Load(object sender, EventArgs e)
        {
            Timer timer1 = new Timer();
            Timer timer2 = new Timer();
            timer1.Interval = 500;
            timer2.Interval = 500;
            val = 200;
            timer1.Tick += (s, eve) => {
                this.Invalidate();
                val += r;
                r += 10;
                Debug.WriteLine($"T1 * Val = {val}");
                if (val >= 550)
                {
                    r = 0;
                    timer1.Stop();
                    timer2.Start();
                }
            };
            timer2.Tick += (s, eve) => {
                this.Invalidate();
                val -= l;
                l -= 10;
                Debug.WriteLine($"T2 * Val = {val}");

                if (val <= 200)
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
