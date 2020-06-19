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
            this.MinimumSize = Size;
            btnClose.Click += (s,e) => this.Close();
            openFileDialog1.Filter = "Rich Text File|*.rtf|Text File|*.txt";
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
                rtfTXTbox.LoadFile(openFileDialog1.FileName, (RichTextBoxStreamType)openFileDialog1.FilterIndex-1);
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
                rtfTXTbox.SaveFile(saveFileDialog1.FileName, (RichTextBoxStreamType)saveFileDialog1.FilterIndex-1);
        }
        DialogeTXT form = new DialogeTXT();
        private void btnMsg_Click(object sender, EventArgs e)
        {
            
            form.Message = "Type Your Text Here";
            if (form.ShowDialog() == DialogResult.OK)
                rtfTXTbox.AppendText(form.Message);
        }
    }
}
