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
        int i = 0;
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = CreateGraphics();
            Timer timer = new Timer();
            timer.Interval = 10;
            timer.Tick += (s,eve) => {
                i = i == 300 ? 0 : i;
                graphics.FillEllipse(Brushes.Aquamarine, 100+i, 400, 50, 50);
            };
            timer.Start();
            base.OnPaint(e);
        }


    }
}
