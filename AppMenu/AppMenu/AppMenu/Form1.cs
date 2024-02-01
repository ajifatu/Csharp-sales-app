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
using AppMenu.Model1;
using AppMenu.Utils;

namespace AppMenu
{
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }
        BdKireneEntities db = new BdKireneEntities();


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            
            var leUser = db.Utilisateur.Where(a => a.IdentifiantUt == txtIdentifiant.Text).FirstOrDefault();
            if (leUser!=null)
            {
                string hash = leUser.MotDePasse;
                using (MD5 md5Hash = MD5.Create())
                {
                    if (Crypte.VerifyMd5Hash(md5Hash, txtMotDePasse.Text, hash))
                    {
                        FrmLayout frm = new FrmLayout();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("l'identifiant ou mot de passe est incorrect");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("l'identifiant ou mot de passe est incorrect");
            }

      
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
