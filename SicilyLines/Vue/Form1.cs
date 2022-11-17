using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Connecte.Controleur;
using Connecte.Modele;
using Connecte.DAL;

namespace SicilyLines
{
    public partial class Form1 : Form
    {
        Mgr monManager;
        List<Secteur> sSec = new List<Secteur>();
        List<Liaison> sLiaison = new List<Liaison>();

        public Form1()
        {
            InitializeComponent();
            monManager = new Mgr();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        // Execution de la fonction qui affiche les secteurs
        public void affiche()

        {
            try
            {
                listBoxSecteur.DataSource = null;
                listBoxSecteur.DataSource = sSec;
                listBoxSecteur.DisplayMember = "Description";
            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        // Execution de la fonction qui affiche les liaisons
        public void afficheLiaison()
        {

            Console.WriteLine("afficheLiaison");
            try
            {
                for (int i = 0; i < sLiaison.Count; i++)
                {
                    {
                        Secteur secteurDepart = monManager.GetSecteurById(sLiaison[i].id_Depart);
                        Secteur secteurArrivee = monManager.GetSecteurById(sLiaison[i].id_Arrivee);
                        //string portDepart = secteurDepart.libelle;
                        //string portArrivee = secteurArrivee.libelle;
                        sLiaison[i].Description2 = secteurDepart.libelle + " => " + secteurArrivee.libelle;
                    }
                    //la ligne en dessous efface ce qui est dans la box
                    listBoxResLiaison.DataSource = null;
                    listBoxResLiaison.DataSource = sLiaison;
                    listBoxResLiaison.DisplayMember = "Description2";
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        // Execution de la fonction qui ajoute un secteur
        public void ajoutSecteur(String unLibelle)

        {
            try
            {
                listBoxSecteur.DataSource = null;
                listBoxSecteur.DataSource = sSec;
                listBoxSecteur.DisplayMember = "Description";
            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        // Execution de la fonction qui supprime un secteur
        public void supprimerSecteur(String supLibelle)

        {
            try
            {
                listBoxSecteur.DataSource = null;
                listBoxSecteur.DataSource = sSec;
                listBoxSecteur.DisplayMember = "Description";
            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        // Execution de la fonction qui modifie un secteur
        public void modifierSecteur(String nouvLibelle)

        {
            try
            {
                listBoxSecteur.DataSource = null;
                listBoxSecteur.DataSource = sSec;
                listBoxSecteur.DisplayMember = "Description";
            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        // Tous les composants du Form1
        private void listBoxSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = listBoxSecteur.SelectedItem as Secteur;
            Console.WriteLine(index.id);
            sLiaison = monManager.ChargementliaisonBD(index.id);
            afficheLiaison();
        }

        private void listBoxResLiaison_SelectedIndexChanged(object sender, EventArgs e)
        {
            afficheLiaison();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            ajoutSecteur(textBoxLibelle.Text);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            sSec = monManager.chargementSecBD();

            affiche();
        }

        private void textBoxLibelle_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            supprimerSecteur(textBoxLibelle.Text);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            modifierSecteur(textBoxLibelle.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
