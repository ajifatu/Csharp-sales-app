using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppVente.Model1;

namespace AppVente
{
    public partial class frmCategorie : Form
    {
        bdVenteEntities db = new bdVenteEntities();
        public frmCategorie()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            dgCategorie.DataSource = db.Categorie.ToList();

        }

        private void resetForm()
        {
            textLibelle.Text = string.Empty;
            textCode.Text = string.Empty;
            dgCategorie.DataSource = db.Categorie.ToList();
            textCode.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Categorie c =new Categorie();
            c.codeCategorie = textCode.Text;
            c.libelleCategorie = textLibelle.Text;
            db.Categorie.Add(c);
            db.SaveChanges();
            resetForm();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            textCode.Text = dgCategorie.CurrentRow.Cells[1].Value.ToString();
            textLibelle.Text = dgCategorie.CurrentRow.Cells[2].Value.ToString();

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgCategorie.CurrentRow.Cells[0].Value.ToString());
            var c= db.Categorie.Find(id);
            c.codeCategorie = textCode.Text;
            c.libelleCategorie = textLibelle.Text;
            db.SaveChanges();
            resetForm();
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgCategorie.CurrentRow.Cells[0].Value.ToString());
            var c = db.Categorie.Find(id);
            db.Categorie.Remove(c);
            db.SaveChanges();
            resetForm();
        }
    }
}
