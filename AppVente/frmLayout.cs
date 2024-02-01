using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;

namespace AppVente
{
    public partial class frmLayout : Form
    {
        public frmLayout()
        {
            InitializeComponent();
        }
        private void fermer()
        {
            Form[] charr = this.MdiChildren;

            foreach (Form chform in charr)
            {
                chform.Close();
            }
        }

        private void seConnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmCategorie f =new frmCategorie();
            f.MdiParent = this;
            f.Show();
        }

        private void produitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmProduit f = new frmProduit();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void frmLayout_load(object sender, EventArgs e)
        {
            Computer myComputer = new Computer();
            this.Width = myComputer.Screen.Bounds.Width;
            this.Height= myComputer.Screen.Bounds.Width;
            this.Location = new Point(0, 0);
        }

        private void seDéconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }

  
}
