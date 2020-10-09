using log4net;
using MySql.Data.MySqlClient;
using Quiz_TP.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ.DataAccess
{
    public static class QuestionDAO 
    {
        private static ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //CRUD Create / Red / Unreaad / Delete(+Read All)

        public static List<Question> FindAll(int idQuiz)
        {
            List<Question> questions = new List<Question>();

            //1.Connexion à une base de données         

            string chaineDeConnexion = Quiz_TP.Properties.Settings.Default.ConnexionString; 
            MySqlConnection connexion = new MySqlConnection(chaineDeConnexion);
            MySqlCommand commande = null;
            MySqlDataReader dataReader = null;

            try
            {
                connexion.Open();

                //2.Préparer envoie d'une commande Mysql
                string requete = "SELECT  enonce, multipleChoice, quizId FROM t_question WHERE quizId" +idQuiz;
                commande = new MySqlCommand(requete, connexion); ;

                //3.Envoyer la commande 
                dataReader = commande.ExecuteReader();              

                while (dataReader.Read())
                {
                    //5.Construir l'objet à reenvoyer 
                    Question quest = new Question()
                    {
                        Enonce = dataReader["enonce"].ToString(),
                        EstChoixMultiple = (bool)dataReader["multipleChoice"], 
                        Id = (int)dataReader["id"],
                        Ordre = (int)dataReader["ordre"]
                    };

                     questions.Add(quest);
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
            return questions;
            
        }
 
        
    }
}
