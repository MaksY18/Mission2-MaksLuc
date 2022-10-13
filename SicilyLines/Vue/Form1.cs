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

namespace SicilyLines
{
    public partial class Form1 : Form
    {
        Mgr monManager;
        List<Secteur> sSec = new List<Secteur>();

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
            try
            {
                listBoxResLiaison.DataSource = null;
                listBoxResLiaison.DataSource = sSec;
                listBoxResLiaison.DisplayMember = "Description2";
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
            affiche();
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
