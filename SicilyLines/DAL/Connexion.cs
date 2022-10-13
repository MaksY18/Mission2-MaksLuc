using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecte
{
    public class ConnexionSql
    {
        private static ConnexionSql connection = null;

        private MySqlConnection mysqlCn;

        private static readonly object mylock = new object();

        private string connString;


        private ConnexionSql(string unProvider, string uneDataBase, string unUid, string unMdp)
        {


            try
            {
                connString = "SERVER=" + unProvider + ";" + "DATABASE=" +
                   uneDataBase + ";" + "UID=" + unUid + ";" + "PASSWORD=" + unMdp + ";";
                try
                {
                    mysqlCn = new MySqlConnection(connString);
                }
                catch (Exception sec)
                {
                    throw (sec);
                }
            }
            catch (Exception sec)
            {
                throw (sec);
            }
        }


        public static ConnexionSql getInstance(string unProvider, string uneDataBase, string unUid, string unMdp)
        {

            lock ((mylock))
            {

                try
                {


                    if (null == connection)
                    { // Premier appel
                        connection = new ConnexionSql(unProvider, uneDataBase, unUid, unMdp);

                    }

                }
                catch (Exception sec)
                {
                    throw (sec);


                }
                return connection;

            }
        }

        public void openConnection()
        {
            try
            {
                mysqlCn.Open();
            }
            catch (Exception sec)
            {
                throw (sec);
            }
        }

        /**
         * Fermeture de la connexion
         */
        public void closeConnection()
        {
            if (mysqlCn.State == System.Data.ConnectionState.Open)
                mysqlCn.Close();
        }

        /**
         * Exécutiuon d'une requête
         */
        public MySqlCommand reqExec(string req)
        {
            MySqlCommand mysqlCom = new MySqlCommand(req, this.mysqlCn);
            return (mysqlCom);
        }
    }

}
