using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecte.Modele
{
    class Bateau
    {
        private String nom;
        private double longueur;
        private double largeur;
        private int vitesse;

        public Bateau (string unNom, double uneLongueur, double uneLargeur, int uneVitesse)
        {
            this.nom = unNom;
            this.longueur = uneLongueur;
            this.largeur = uneLargeur;
            this.vitesse = uneVitesse;
        }

        public String getNom()
        {
            return this.nom;
        }
        public void setNom(String nouvNom)
        {
            this.nom = nouvNom;
        }
        public double getLongueur()
        {
            return this.longueur;
        }
        public void setLongueur(double nouvLongueur)
        {
            this.longueur = nouvLongueur;
        }
        public double getLargeur()
        {
            return this.largeur;
        }
        public void setLargeur(double nouvLargeur)
        {
            this.largeur = nouvLargeur;
        }
        public int getVitesse()
        {
            return this.vitesse;
        }
        public void setVitesse(int nouvVitesse)
        {
            this.vitesse = nouvVitesse;
        }
    }
}
