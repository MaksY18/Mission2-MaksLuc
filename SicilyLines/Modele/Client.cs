using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecte.Modele
{
    class Client
    {
        private String nom;
        private String adresse;
        private int cp;
        private String ville;

        public Client(String unNom, String uneAdresse, int unCp, String uneVille)
        {
            this.nom = unNom;
            this.adresse = uneAdresse;
            this.cp = unCp;
            this.ville = uneVille;
        }

        public String getNom()
        {
            return this.nom;
        }
        public void setNom(String unNom)
        {
            this.nom = unNom;
        }
        public String getAdresse()
        {
            return this.adresse;
        }
        public void setAdresse(String uneAdresse)
        {
            this.adresse = uneAdresse;
        }
        public int getCp()
        {
            return this.cp;
        }
        public void setCp(int unCp)
        {
            this.cp = unCp;
        }
        public String getVille()
        {
            return this.ville;
        }
        public void setVille(String uneVille)
        {
            this.ville = uneVille;
        }
    }
}
