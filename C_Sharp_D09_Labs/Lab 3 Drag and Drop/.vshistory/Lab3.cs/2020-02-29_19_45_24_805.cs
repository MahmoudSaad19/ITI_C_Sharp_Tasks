using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3_Drag_and_Drop
{
    public partial class Lab3 : Form
    {
        public Lab3()
        {
            InitializeComponent();
        }
        Graphics graphics = CreateGraphics();

        private void Lab3_Load(object sender, EventArgs e)
        {
            graphics.DrawRectangle(Pens.Red, 10, 10, 100, 100);
            graphics.FillRectangle(Brushes.OrangeRed, 10, 10, 100, 100);
        }

        private void Lab3_MouseClick(object sender, MouseEventArgs e)
        {

            Graphics graphics = CreateGraphics();
            graphics.DrawRectangle(Pens.Red, 10, 10, 100, 100);
            graphics.FillRectangle(Brushes.OrangeRed, 10, 10, 100, 100);
        }
    }
}
