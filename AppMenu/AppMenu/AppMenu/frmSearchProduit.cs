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
    public partial class frmSearchProduit : Form
    {
        public frmSearchProduit()
        {
            InitializeComponent();
        }
        BdKireneEntities db = new BdKireneEntities();
        LoadComboBox load = new LoadComboBox();

        private void txtPU_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void frmSearchProduit_Load(object sender, EventArgs e)
        {
            cbbCategorie.DataSource = load.loadCategorie();
            cbbCategorie.DisplayMember = "Text";
            cbbCategorie.ValueMember = "Value";

        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            var liste = db.VListeProduitCategorie.ToList();

            if(!string.IsNullOrEmpty(txtProduit.Text) )
            {
                liste = liste.Where(a=>a.DesignationProduit.ToLower().Contains(txtProduit.Text.ToLower())).ToList();
            }

            if (!string.IsNullOrEmpty(cbbCategorie.Text))
            {
                liste = liste.Where(a => a.CodeCategorie.ToLower()==cbbCategorie.SelectedValue.ToString()).ToList() ;
            }

            if (!string.IsNullOrEmpty(txtPU.Text))
            {
                double p = double.Parse(txtPU.Text) ;
                liste = liste.Where(a => a.PU<=p).ToList();
            }

            dgSearchProduit.DataSource = liste;
        }
    }
}
