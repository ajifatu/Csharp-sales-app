using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appvente.Model;

namespace Appvente.utils
{
    public class loadComboBox
    {
        bdVenteEntities2 db = new bdVenteEntities2();
         public List<ListItem> fillCategorie()
        {
            List<ListItem> laliste = new List<ListItem>();
            var liste = db.Categorie.ToList();
            laliste.Add(new ListItem()
            {
                Value = null,
                Text = "Selectionner .........."
            });
            foreach (var t in liste)
            {
                var item = new ListItem
                {
                    Value = t.CodeCategorie.ToString(),
                    Text = t.LibelleCategorie.ToString()
                };
                laliste.Add(item);
            }
            return laliste;
        }


        public List<ListItem> fillProfil()
        {
            List<ListItem> laliste = new List<ListItem>();
            var liste = db.Profil.ToList();
            laliste.Add(new ListItem()
            {
                Value = null,
                Text = "Selectionner .........."
            });
            foreach (var t in liste)
            {
                var item = new ListItem
                {
                    Value = t.CodeProfil.ToString(),
                    Text = t.LibelleProfil.ToString()
                };
                laliste.Add(item);
            }
            return laliste;
        }

    }


}
