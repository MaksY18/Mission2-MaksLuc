using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecte.Modele
{
    class Type
    {
        private String libelle;

        public Type(String unLibelle)
        {
            this.libelle = unLibelle;
        }

        public String getLibelle()
        {
            return libelle;
        }
        public void setLibelle(String unLibelle)
        {
            this.libelle = unLibelle;
        }
    }
}
