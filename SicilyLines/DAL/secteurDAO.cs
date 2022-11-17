using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Connecte.Modele;
using MySql.Data.MySqlClient;
using SicilyLines;

namespace Connecte.DAL
{
    public class secteurDAO
    {
        private static string provider = "127.0.0.1";

        private static string dataBase = "bd-sicilylines";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;

        // Ajout d'un secteur
        public void ajoutSecteur(String unLibelle)
        {
            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("INSERT INTO secteur (Libelle) VALUES ('" + unLibelle + "')");


                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();



            }

            catch (Exception sec)
            {

                throw (sec);
            }
        }

        // Suppression d'un secteur
        public void supprimerSecteur(String supLibelle)
        {
            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("DELETE FROM secteur WHERE libelle='" + supLibelle + "'");


                int p = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();



            }

            catch (Exception sec)
            {

                throw (sec);
            }
        }

        // Modification d'un secteur
        public void modifierSecteur(String nouvLibelle)
        {
            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("UPDATE secteur SET libelle ='" + nouvLibelle + "'");


                int m = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();



            }

            catch (Exception sec)
            {

                throw (sec);
            }
        }

        // Mise à jour d'un secteur
        public static void updateSecteur(Secteur s)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("");


                int n = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();



            }

            catch (Exception sec)
            {

                throw (sec);
            }


        }

        // Récupération de la liste des secteurs
        public static List<Secteur> getSecteur()
        {
            List<Secteur> lc = new List<Secteur>();

            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec("Select * from Secteur");
                MySqlDataReader reader = Ocom.ExecuteReader();
                Secteur s;

                while (reader.Read())
                {
                    string numero = (string)reader.GetValue(0);
                    string libelle = (string)reader.GetValue(1);
                    //Instanciation d'un Secteur
                    s = new Secteur(numero, libelle);
                    // Ajout de ce secteur à la liste 
                    lc.Add(s);
                }
                reader.Close();
                maConnexionSql.closeConnection();
                // Envoi de la liste au Manager
                return (lc);
            }
            catch (Exception sec)
            {
                throw (sec);
            }
        }

        //permet de chercher le secteur grace a wantedid
        public Secteur getSecteurById(string WantedId)
        {

            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec("Select * from Secteur Where ID = " + WantedId);
                MySqlDataReader reader2 = Ocom.ExecuteReader();
                Object[] values = new Object[reader2.FieldCount];
                while (reader2.Read())
                {
                    reader2.GetValues(values);
                    reader2.Close();
                    maConnexionSql.closeConnection();
                    //string unId, string unIdR, string unIdD, string unIdA, string unIdP, String uneDuree
                    return new Secteur(values[0].ToString(), values[1].ToString());
                }
                return null;

            }
            catch (Exception sec)
            {
                throw (sec);
            }
            return null;

        }

        public Secteur setSecteurById(string WantedId)
        {

            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec("Delete from Secteur Where ID = " + WantedId);
                MySqlDataReader reader2 = Ocom.ExecuteReader();
                Object[] values = new Object[reader2.FieldCount];
                while (reader2.Read())
                {
                    reader2.GetValues(values);
                    reader2.Close();
                    maConnexionSql.closeConnection();
                    //string unId, string unIdR, string unIdD, string unIdA, string unIdP, String uneDuree
                    return new Secteur(values[0].ToString(), values[1].ToString());
                }
                return null;

            }
            catch (Exception sec)
            {
                throw (sec);
            }
            return null;
        }
    }
}

