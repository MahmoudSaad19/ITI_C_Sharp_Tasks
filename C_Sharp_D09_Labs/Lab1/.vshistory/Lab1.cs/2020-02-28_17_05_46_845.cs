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
            openFileDialog1.Filter = "All files (*.*)|*.*";
            saveFileDialog1.Filter = "Rich Text File|*.rtf|Text File|*.txt";
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = rtfTXTbox.SelectionColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                rtfTXTbox.SelectionColor = colorDialog1.Color;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                rtfTXTbox.LoadFile(openFileDialog1.InitialDirectory, (RichTextBoxStreamType)openFileDialog1.FilterIndex);
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            
            fontDialog1.Font = rtfTXTbox.SelectionFont;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                rtfTXTbox.SelectionFont = fontDialog1.Font;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                rtfTXTbox.SaveFile(saveFileDialog1.InitialDirectory, (RichTextBoxStreamType)saveFileDialog1.FilterIndex);
        }
    }
}
