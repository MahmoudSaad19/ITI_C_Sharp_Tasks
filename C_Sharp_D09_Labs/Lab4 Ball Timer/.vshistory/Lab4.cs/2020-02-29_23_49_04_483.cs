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
        int w;
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = CreateGraphics();
            Timer timer = new Timer();
            w = Width;
            timer.Interval = 10;
            timer.Tick += (s,eve) => {
                i = i == 300 ? 0 : i;
                Image image = Image.FromFile("pic.jpg");
                graphics.Clear(Color.White);
                graphics.FillEllipse(Brushes.Lavender, w/2 - i++, 400, 70, 70);
            };
            timer.Start();
            base.OnPaint(e);
        }


    }
}
