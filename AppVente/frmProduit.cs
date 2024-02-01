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
    public partial class frmProduit : Form
    {
        bdVenteEntities db = new bdVenteEntities();
        public frmProduit()
        {
            InitializeComponent();
        }

        private void frmProduit_Load(object sender, EventArgs e)
        {
            dgProduit.DataSource = db.Produit.ToList();
            cbbCategorie.DataSource = load.loadCategorie();
            cbbCategorie.ValueMember = "Value";
            cbbCategorie.DisplayMember = "Text";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
                int? id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
                Produit p = db.Produit.Find(id);
                db.Produit.Remove(p);
                db.SaveChanges();
                reser();
           
        }
        private void resetForm()
        {
            txtid.Text = string.Empty;
            txtdesignation.Text = string.Empty;
            txtdescription.Text = string.Empty;
            txtcodeP.Text = string.Empty;
            txtprixP.Text = string.Empty;
            txtqteMin.Text = string.Empty;
            txtqteCritique.Text = string.Empty;
            cbbCategorie.DataSource = load.loadCategorie();
            cbbCategorie.ValueMember = "Value";
            cbbCategorie.DisplayMember = "Text";

            dgProduit.DataSource = db.Produit.ToList();
            txtid.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produits p = new Produit;

            p.CodeProduit = int.Parse(txtCode.Text);
            p.Designation = txtdesignation.Text;
            p.Description = txtdescription.Text;
            p.CodeProduit = txtcodeP.Text;
            p.PrixProduit = CheikEnter.checkIsFloat(txtprixP.Text)? float.Parse(txtPrixUnitaire.Text) : 0;
            p.QteMin=int.Parse(txtqteMin.Text);
            p.QteCritique =int.Parse( QteCritique.Text);
            p.CodeCategorie = cbbCategorie.SelectedValue.ToString();
            db.Produit.Add(p);
            db.SaveChanges();
            resetForm();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnrechercher_Click(object sender, EventArgs e)
        {
            var Liste=db.Produit.ToList();
            if(string.IsNullOrEmpty(txtRCode.Text))
            {
                Liste=Liste.Where(a=>a.CodeProduit.ToUpper().Contains(txtRCode.Text.ToUpper())).ToList();
            }

            if (string.IsNullOrEmpty(txtRDesignation.Text))
            {
                Liste = Liste.Where(a => a.Designation.ToUpper().Contains(txtRDesignation.Text.ToUpper())).ToList();
            }
            dgProduit.DataSource = Liste;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
           Produits p= db.Produit.Find(id);
            db.Produit.Remove(p);
            db.SaveChanges();
            resetForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            var p = db.Produit.Find(id);

            p.Designation = txtdesignation.Text;
            p.Description = txtdescription.Text;
            p.PrixProduit = CheikEnter.checkIsFloat(txtprixP.Text) ? float.Parse(txtPrixUnitaire.Text) : 0;
            p.PrixProduit = txtprixP.Text;
            p.QteMin = txtqteMin.Text;
            p.QteCritique = QteCritique.Text;
            p.CodeCategorie = cbbCategorie.SelectedValue.ToString();



            db.Produit.Add(p);
            db.SaveChanges();
            resetForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtdesignation.Text = dgProduit.CurrentRow.Cells[1].Value.ToString();
            txtdescription.Text = dgProduit.CurrentRow.Cells[2].Value.ToString();
            txtcodeP.Text = dgProduit.CurrentRow.Cells[3].Value.ToString();
            txtprixP.Text = dgProduit.CurrentRow.Cells[4].Value.ToString();
            txtqteMin.Text = dgProduit.CurrentRow.Cells[5].Value.ToString();
            QteCritique.Text = dgProduit.CurrentRow.Cells[6].Value.ToString();

        }

    }
}
