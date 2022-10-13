using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecte.Modele
{
    class Categorie
    {
        private String libelle;

        public Categorie(String unLibelle)
        {
            this.libelle = unLibelle;
        }
        public String getLibelle()
        {
            return this.libelle;
        }
        public void setLibelle(String nouvLibelle)
        {
            this.libelle = nouvLibelle;
        }
    }
}
