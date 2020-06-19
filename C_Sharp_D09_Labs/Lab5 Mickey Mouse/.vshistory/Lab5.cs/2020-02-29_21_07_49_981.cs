using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            path.AddEllipse(0, 0, this.Width, this.Height);
            path.AddRectangle(new Rectangle(0, 0, 100, 100));
            path.FillMode = FillMode.Winding;

            this.Region = new Region(path);
        }
    }
}
