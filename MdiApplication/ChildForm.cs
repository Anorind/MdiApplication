using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MdiApplication
{
    public partial class ChildForm : Form
    {
        private String BufferText;
        public ChildForm()
        {
            InitializeComponent();
        }

        private void ТoggleMenuItem_Click(object sender, EventArgs e)
        {
            if (ТoggleMenuItem.Checked)
            {
                ТoggleMenuItem.Checked = false;
                ChildTextBox.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                ТoggleMenuItem.Checked = true;
                ChildTextBox.ForeColor = System.Drawing.Color.Blue;
            }
        }
        public void Cut()
        {
            this.BufferText = ChildTextBox.SelectedText;
            ChildTextBox.SelectedText = "";
        }
        public void Copy()
        {
            this.BufferText = ChildTextBox.SelectedText;
        }
        public void Paste()
        {
            ChildTextBox.SelectedText = this.BufferText;
        }
        public void SelectAll()
        {
            ChildTextBox.SelectAll();
        }
        public void Delete()
        {
            ChildTextBox.SelectedText = "";
            this.BufferText = "";
        }

        private void копіюванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void вирізатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void вставитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void видалитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void виділитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void копіюватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void вирізатиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void вставитиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void видалитиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void виділитиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SelectAll();
        }
    }
}
