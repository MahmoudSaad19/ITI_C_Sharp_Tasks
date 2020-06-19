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

        }
        int r = 0;
        int l = 400;

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = CreateGraphics();
            Timer timer1 = new Timer();
            Timer timer2 = new Timer();
            timer1.Interval = 10;
            timer2.Interval = 10;
            timer1.Tick += (s, eve) => {

                Image image = Image.FromFile("pic.jpg");
                graphics.Clear(Color.White);
                graphics.FillEllipse(Brushes.OrangeRed, 100 + r++, 400, 70, 70);
                if (r == 400)
                {
                    r = 0;
                    timer1.Stop();
                    timer2.Start();
                }
            };
            timer2.Tick += (s, eve) => {

                Image image = Image.FromFile("pic.jpg");
                graphics.Clear(Color.White);
                graphics.FillEllipse(Brushes.OrangeRed, 100 + l--, 400, 70, 70);
                if (l == 0)
                {
                    l = 400;
                    timer2.Stop();
                    timer1.Start();
                }
            };
            //timer1.Start();
            base.OnPaint(e);
        }


    }
}
