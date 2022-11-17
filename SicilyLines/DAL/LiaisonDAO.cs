using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Connecte.Modele;
using MySql.Data.MySqlClient;
using SicilyLines;

namespace Connecte.DAL
{
    public class LiaisonDAO
    {
        private static string provider = "127.0.0.1";

        private static string dataBase = "bd-sicilylines";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;
        private string supLibelle;

        // Ajout d'un secteur
        /* public void ajoutLiaison(String unLibelle)
         {
             try
             {


                 maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                 maConnexionSql.openConnection();


                 Ocom = maConnexionSql.reqExec("INSERT INTO liaison (Libelle) VALUES ('" + unLibelle + "')");


                 int i = Ocom.ExecuteNonQuery();



                 maConnexionSql.closeConnection();



             }

             catch (Exception sec)
             {

                 throw (sec);
             }
         }*/

        // Suppression d'un secteur
        public void supprimerLiaison(Liaison l, string id, string name)
         {
             try
             {


                 maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                 maConnexionSql.openConnection();


                 Ocom = maConnexionSql.reqExec("DELETE FROM secteur WHERE ID_REGROUPER='" +id+ supLibelle + "'");


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
        public static List<Liaison> getLiaison(string WantedId)
        {

            List<Liaison> lc = new List<Liaison>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("Select * from liaison Where ID_DEPART = " + WantedId + " OR ID_ARRIVEE = " + WantedId);


                MySqlDataReader reader = Ocom.ExecuteReader();

                List<Liaison> s = new List<Liaison>();
                Object[] values = new Object[reader.FieldCount];
                while (reader.Read())
                {
                    reader.GetValues(values);
                    //string unId, string unIdR, string unIdD, string unIdA, string unIdP, String uneDuree
                    s.Add(new Liaison(values[0].ToString(),
                                      values[1].ToString(),
                                      values[2].ToString(),
                                      values[3].ToString(),
                                      values[4].ToString(),
                                      values[5].ToString()
                                      ));
                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (s);


            }

            catch (Exception sec)
            {

                throw (sec);

            }


        }

    }
}
