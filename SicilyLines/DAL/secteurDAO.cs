using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


        // Mise à jour d'un employé

        public static void updateSecteur(Secteur s)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("update employe set login= '" + s.Login + "' where id = " + s.Id);


                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();



            }

            catch (Exception sec)
            {

                throw (sec);
            }


        }

        // Récupération de la liste des employés
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

                    //Instanciation d'un Emplye
                    s = new Secteur(numero, libelle);

                    // Ajout de cet employe à la liste 
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

    }
}

