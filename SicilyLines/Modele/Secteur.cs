using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecte.Modele
{
    public class Secteur
    {
        private string id;
        private String libelle;
        private String login;

        public string Login { get => login; set => login = value; }
        public string Id { get => id;}

        public Secteur (string unId, String unLibelle)
        {
            this.id = unId;
            this.libelle = unLibelle;
        }

        public String getLibelle()
        {
            return this.libelle;
        }
        public void setLibelle(String unLibelle)
        {
            this.libelle = unLibelle;
        }

        // Fonction d'affichage
        public string Description
        {
            get => "Id : " + this.id + " Libelle : " + this.libelle;
        }
    }
}
