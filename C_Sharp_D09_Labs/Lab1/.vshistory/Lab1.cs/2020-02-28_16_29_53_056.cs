using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Lab1 : Form
    {
        public Lab1()
        {
            InitializeComponent();
            btnClose.Click += (s,e) => this.Close();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            //colorDialog1.Color = rtfTXTbox.SelectedText
            //rtfTXTbox.SelectedText
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            
            //fontDialog1.Font = rtfTXTbox.SelectedText;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                rtfTXTbox.SelectedRtf = fontDialog1.Font.ToString();
        }
    }
}
