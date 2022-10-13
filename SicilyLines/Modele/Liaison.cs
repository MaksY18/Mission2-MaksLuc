using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecte.Modele
{
    class Liaison
    {
        private string id;
        private string id_Regrouper;
        private string id_Depart;
        private string id_Arrivee;
        private string id_Port;
        private String duree;

        public Liaison(string unId, string unIdR, string unIdD, string unIdA, string unIdP, String uneDuree)
        {
            this.id = unId;
            this.id_Regrouper = unIdR;
            this.id_Depart = unIdD;
            this.id_Arrivee = unIdA;
            this.id_Port = unIdP;
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
