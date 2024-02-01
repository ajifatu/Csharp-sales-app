using Microsoft.VisualBasic.Devices;
using System;
using System.Collections;
using System.Collections.Generic; 
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMenu
{
    public partial class FrmLayout : Form
    {
        public FrmLayout()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void seDeconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm1 frm = new Frm1();
            //frm.Show();
            this.Close();
        }

       

        private void formBleuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
            fermer();
            FrmB frm = new FrmB();
            frm.MdiParent = this;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }

        private void formVertToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fermer();
            FrmR frm = new FrmR();
            frm.MdiParent = this;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }


        private void fermer()
        {
            Form[] charr = this.MdiChildren;

            //For each child form set the window state to Maximized 
            foreach (Form chform in charr)
            {
                //chform.WindowState = FormWindowState.Maximized;
                chform.Close();
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLayout_Load(object sender, EventArgs e)
        {
            Computer myComputer = new Computer();
            this.Width = myComputer.Screen.Bounds.Width;
            this.Height = myComputer.Screen.Bounds.Height;
            this.Location = new Point(0, 0);
        }

        private void categorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmCategorie frm = new frmCategorie();
            frm.MdiParent = this;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }

        private void produitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmProduit frm = new frmProduit();
            frm.MdiParent = this;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }

        private void rechercheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmSearchProduit frm = new frmSearchProduit();
            frm.MdiParent = this;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }

        private void utilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmUtilisateur frm = new frmUtilisateur();
            frm.MdiParent = this;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;

        }
    }
    
}
