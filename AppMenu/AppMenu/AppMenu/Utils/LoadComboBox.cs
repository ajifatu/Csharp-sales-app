using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppMenu.Model1;

namespace AppMenu.Utils
{
    internal class LoadComboBox
    {
        BdKireneEntities db = new BdKireneEntities();

        public List<ListeSelectedViewModel> loadCategorie()
        {
            List<ListeSelectedViewModel> laListe = new List<ListeSelectedViewModel>();
            laListe.Add(new ListeSelectedViewModel
            {
                Value = null,
                Text = "Selectionner ......."

            }) ;
            var liste = db.Categorie.ToList();
            foreach (var c in liste)
            {
                laListe.Add(new ListeSelectedViewModel
                {
                    Value = c.CodeCategorie,
                    Text = c.libelleCategori
                });
            }

            return laListe;

        }

        public List<ListeSelectedViewModel> loadProfil()
        {
            List<ListeSelectedViewModel> laListe = new List<ListeSelectedViewModel>();
            laListe.Add(new ListeSelectedViewModel
            {
                Value = null,
                Text = "Selectionner ......."

            });
            var liste = db.Profil.ToList();
            foreach (var p in liste)
            {
                laListe.Add(new ListeSelectedViewModel
                {
                    Value = p.CodeProfil,
                    Text = p.LibelleProfil
                });
            }

            return laListe;

        }



    }
}
