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
            GraphicsPath path = new GraphicsPath();

            path.AddEllipse(100, 0, this.Width-200, this.Height-100);
            path.AddEllipse(0, 0, 200, 200);
            path.AddEllipse(Width-200, 0 , 200, 200);
            path.FillMode = FillMode.Winding;

            this.Region = new Region(path);
        }
    }
}
