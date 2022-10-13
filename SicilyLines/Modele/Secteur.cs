using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecte.Modele
{
    public class Secteur
    {
        private int id;
        private String libelle;
        private String login;

        public string Login { get => login; set => login = value; }
        public int Id { get => id;}

        public Secteur (int unId, String unLibelle)
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
    }
}
