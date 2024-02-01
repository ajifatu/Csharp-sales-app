using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Appvente.Model;
using Appvente.utils;

namespace Appvente
{
    public partial class frmUtilisateur : Form
    {
        bdVenteEntities2 db = new bdVenteEntities2();
        loadComboBox load = new loadComboBox();
        public frmUtilisateur()
        {
            InitializeComponent();
        }

        private void frmUtilisateur_Load(object sender, EventArgs e)
        {
            dgUtilisateur.DataSource = db.Utilisateur.Select(x => new { x.idUtilisateur, x.Identifiant,x.Email,x.CodeProfil}).ToList();
            cbbProfil.DataSource = load.fillProfil();
            cbbProfil.DisplayMember = "Text";
            cbbProfil.ValueMember = "Value";
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            using(MD5 md5Hash = MD5.Create())
            {
                Utilisateur ut =new Utilisateur();
                ut.Identifiant=txtIdentifiant.Text;
                ut.MotDepasse = Cripts.GetMd5Hash(md5Hash, "passer");
                ut.Email=txtEmail.Text;
                ut.CodeProfil = cbbProfil.SelectedValue.ToString();
                db.Utilisateur.Add(ut);
                db.SaveChanges();
                resetForm();
            }

        }
        private void resetForm()
        {
            txtEmail.Text = String.Empty;
            txtIdentifiant.Text = String.Empty;
            dgUtilisateur.DataSource = db.Utilisateur.Select(x => new { x.idUtilisateur, x.Identifiant, x.Email, x.CodeProfil }).ToList();
            cbbProfil.DataSource = load.fillProfil();
            cbbProfil.DisplayMember = "Text";
            cbbProfil.ValueMember = "Value";
            txtIdentifiant.Focus();
        }
    }
}
