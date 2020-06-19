using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        int l = 400;
        int val;

        protected override void OnPaint(PaintEventArgs e)
        {
            graphics.FillEllipse(Brushes.OrangeRed, val, 500, 70, 70);
            base.OnPaint(e);
        }

        private void Lab4_Load(object sender, EventArgs e)
        {
            Timer timer1 = new Timer();
            Timer timer2 = new Timer();
            timer1.Interval = 10;
            timer2.Interval = 10;
            val = 100;
            timer1.Tick += (s, eve) => {
                this.Invalidate();
                val += r++;
                if (r == 400)
                {
                    r = 0;
                    timer1.Stop();
                    timer2.Start();
                }
            };
            timer2.Tick += (s, eve) => {
                this.Invalidate();
                val -= l--;
                if (l == 0)
                {
                    l = 400;
                    timer2.Stop();
                    timer1.Start();
                }
            };
            timer1.Start();
        }
    }
}
