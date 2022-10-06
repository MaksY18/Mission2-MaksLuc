using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicilyLines
{
    class Port
    {
        private String nom;

        public Port (String unNom)
        {
            this.nom = unNom;
        }

        public String getNom()
        {
            return this.nom;
        }
        public void setNom(String nouvNom)
        {
            this.nom = nouvNom;
        }
    }
}
