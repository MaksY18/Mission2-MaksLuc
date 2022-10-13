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

        private void listBoxSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxResLiaison_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

        }
    }
}
