using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Connecte.DAL;
using Connecte.Modele;

namespace Connecte.Controleur
{
    public class Mgr
    {
        secteurDAO secDAO = new secteurDAO();

        List<Secteur> maListeSecteur;

        public Mgr()
        {

            maListeSecteur = new List<Secteur>();
        }



        // Récupération de la liste des employés à partir de la DAL
        public List<Secteur> chargementSecBD()
        {

            maListeSecteur = secteurDAO.getSecteur();

            return (maListeSecteur);
        }


        // Mise à jour d'un employé  dans la DAL
        public void updateSecteur(Secteur s)
        {

            secteurDAO.updateSecteur(s);

        }
    }
}
