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
        LiaisonDAO liaisonDAO = new LiaisonDAO();

        public List<Secteur> maListeSecteur;
        /**/public List<Liaison> maListeLiaison;
        public Mgr()
        {

            maListeSecteur = new List<Secteur>();
            /**/
            maListeLiaison = new List<Liaison>();
        }

        /*public List<Liaison> chargementSLiaisonBD()
        {

            maListeLiaison = secteurDAO.getLiaison();

            return (maListeLiaison);
        }*/

        // Récupération de la liste des secteurs à partir de la DAL
        public List<Secteur> chargementSecBD()
        {

            maListeSecteur = secteurDAO.getSecteur();

            return (maListeSecteur);
        }
        public List<Liaison> ChargementliaisonBD(string WantedID)
        {

            maListeLiaison = LiaisonDAO.getLiaison(WantedID);

            return (maListeLiaison);
        }

        public Secteur GetSecteurById(string WantedId)
        {
            return secDAO.getSecteurById(WantedId);
        }

        public Secteur SetSecteurById(string WantedId)
        {
            return secDAO.setSecteurById(WantedId);
        }


        // Mise à jour d'un secteur dans la DAL
        public void updateSecteur(Secteur s)
        {

            secteurDAO.updateSecteur(s);

        }

        //Suppression d'un secteur
        /*public void supprimerSecteur(Secteur s)
        {

            secteurDAO.supprimerSecteur(s);

        }*/
    }
}