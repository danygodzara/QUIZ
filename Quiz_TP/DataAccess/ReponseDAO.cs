using log4net;
using MySql.Data.MySqlClient;
using QUIZ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_TP.DataAccess
{
    class ReponseDAO
    {
        private static ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //CRUD Create / Red / Unreaad / Delete(+Read All)

        public static List<Reponses> FindAll(int IdQues)
        {
            List<Reponses> reponses = new List<Reponses>();

            //1.Connexion à une base de données         

            string chaineDeConnexion = Properties.Settings.Default.ConnexionString;
            MySqlConnection connexion = new MySqlConnection(chaineDeConnexion);
            MySqlCommand commande = null;
            MySqlDataReader dataReader = null;

            try
            {
                connexion.Open();

                //2.Préparer envoie d'une commande Mysql
                string requete = "SELECT text, correct, questionId FROM t_reponse WHERE questionId" + 1;//IdQues;
                commande = new MySqlCommand(requete, connexion); ;

                //3.Envoyer la commande 
                dataReader = commande.ExecuteReader();

                while (dataReader.Read())
                {
                    //5.Construir l'objet à reenvoyer 
                    Reponses repon = new Reponses()
                    {
                        Text = dataReader["text"].ToString(),
                        EstCorrecte = (bool)dataReader["correct"],
                        Id = (int)dataReader["questionId"]

                    };


                    reponses.Add(repon);
                }
            }
            catch (Exception ex)
            {

                log.Error(ex.Message);
            }

            finally
            {
                //Fermer la connexion
                dataReader?.Close();
                connexion?.Dispose();
                connexion.Close();
            }
            return reponses;
        }
    }
}
