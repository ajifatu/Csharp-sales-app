using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppMenu.Model1;
using AppMenu.Utils;

namespace AppMenu
{   
    
    public partial class frmProduit : Form
    {
        BdKireneEntities db = new BdKireneEntities();
        LoadComboBox load = new LoadComboBox();
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

        private void reser()
        {
            txtCode.Text = string.Empty;
            txtDesignation.Text = string.Empty;
            txtPrixUnitaire.Text = string.Empty;
            txtQuantiteCritique.Text = string.Empty;
            txtQuantiteMinimal.Text = string.Empty;
            dgProduit.DataSource = db.Produit.ToList();
            cbbCategorie.DataSource = load.loadCategorie();
            cbbCategorie.ValueMember = "Value";
            cbbCategorie.DisplayMember = "Text";
            txtCode.Focus();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Produit p = new Produit();
            p.CodeProduit = txtCode.Text;
            p.DesignationProduit = txtDesignation.Text;
            p.PU = CheikEnter.checkIsFloat(txtPrixUnitaire.Text) ? float.Parse(txtPrixUnitaire.Text) : 0;
            p.QteMin = int.Parse(txtQuantiteMinimal.Text);
            p.QteCri = int.Parse(txtQuantiteCritique.Text);
            p.CodeCategorie = cbbCategorie.SelectedValue.ToString();
            db.Produit.Add(p);
            db.SaveChanges();
            reser();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            Produit p = db.Produit.Find(id);
            p.CodeProduit = txtCode.Text;
            p.DesignationProduit = txtDesignation.Text;
            p.PU = CheikEnter.checkIsFloat(txtPrixUnitaire.Text)?float.Parse(txtPrixUnitaire.Text):0;
            p.QteMin = int.Parse(txtQuantiteMinimal.Text);
            p.QteCri = int.Parse(txtQuantiteCritique.Text);
            p.CodeCategorie = cbbCategorie.SelectedValue.ToString();
            db.Produit.Add(p);
            db.SaveChanges();
            reser();

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {       
            txtCode.Text = dgProduit.CurrentRow.Cells[1].Value.ToString();
            txtDesignation.Text = dgProduit.CurrentRow.Cells[2].Value.ToString();
            txtPrixUnitaire.Text = dgProduit.CurrentRow.Cells[3].Value.ToString();
            txtQuantiteMinimal.Text = dgProduit.CurrentRow.Cells[4].Value.ToString();
            txtQuantiteCritique.Text = dgProduit.CurrentRow.Cells[5].Value.ToString();
            cbbCategorie.SelectedValue = dgProduit.CurrentRow.Cells[6].Value;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            Produit p = db.Produit.Find(id);
            db.Produit.Remove(p);
            db.SaveChanges();
            reser();
        }
    }
}
