using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace niceui
{
    public partial class frmAnalytics : Form
    {
        public frmAnalytics()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.textBoxCellsPerModule.Text = this.textBoxCellsPerModule.Text;
                this.textBoxTotalModules.Text = this.textBoxTotalModules.Text;
            }
        }

        private void textBoxCellsPerModule_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyCode == Keys.Enter)
            {
                string text = this.textBoxCellsPerModule.Text;
                this.textBoxCellsPerModule.Text = text;
                Thread.Sleep(1000);
                textBoxTotalModules.Focus();
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
