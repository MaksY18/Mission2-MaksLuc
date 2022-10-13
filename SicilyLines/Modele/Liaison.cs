using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecte.Modele
{
    class Liaison
    {
        private int id;
        private String duree;

        public Liaison(int unId, String uneDuree)
        {
            this.id = unId;
            this.duree = uneDuree;
        }

        public String getDuree()
        {
            return duree;
        }
        public void setDuree(String uneDuree)
        {
            this.duree = uneDuree;
        }
    }
}
