using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecte.Modele
{
    public class Liaison
    {
        public string id { get; }
        private string id_Regrouper;
        public string id_Depart;
        public string id_Arrivee;
        private string id_Port;
        private String duree;
        public string Description2 { get; set; }

        public Liaison(string unId, string unIdR, string unIdD, string unIdA, string unIdP, String uneDuree)
        {
            this.id = unId;
            this.id_Regrouper = unIdR;
            this.id_Depart = unIdD;
            this.id_Arrivee = unIdA;
            this.id_Port = unIdP;
            this.duree = uneDuree;
            this.Description2 = "Id : " + this.id + " Duree :" + this.duree;
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
