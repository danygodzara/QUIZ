using log4net;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ.DataAccess
{
    public static class QuestionDao
    {
        private static ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //CRUD Create / Red / Unreaad / Delete(+Read All)

        public static List<Question2> FindAll()
        {
            List<Question2> questions = new List<Question2>();

            //1.Connexion à une base de données         

            string chaineDeConnexion = Properties.Settings.Default.ConnexionString; 
            MySqlConnection connexion = new MySqlConnection(chaineDeConnexion);
            MySqlCommand commande = null;
            MySqlDataReader dataReader = null;

            try
            {
                connexion.Open();

                //2.Préparer envoie d'une commande Mysql
                string requete = "SELECT id, enonce, multipleChoice, ordre FROM t_question";
                commande = new MySqlCommand(requete, connexion); ;

                //3.Envoyer la commande 
                dataReader = commande.ExecuteReader();              

                while (dataReader.Read())
                {
                    //5.Construir l'objet à reenvoyer 
                    Question2 quest = new Question2()
                    {
                        Enonce = dataReader["enonce"].ToString(), //ToString para convertir el resultado en chaîne de caracter 
                        EstChoixMultiple = (bool)dataReader["multipleChoice"], //cast= conversion en este caso el "multiple choice" en entero y verificamos que la conversion sea igual a 1
                        Id = (int)dataReader["id"],
                        Ordre = (int)dataReader["ordre"]
                    };


                    questions.Add(quest); // para agregarlo en la lista
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

 /*       public static void Insert(Question nouvelleQuestion)
        {

            //Ouvrir la connexion
            string chaineDeConnexion = Properties.Settings.Default.ConnexionString;
            try
            {
                using (MySqlConnection connexion = new MySqlConnection(chaineDeConnexion)) //se pone using porque va a llamar automaticamente "dispose" asi que este se cerrara SOLO SIRVE SI TENEMOS EL DISPOSE EN NUESTRA VARIABLE
                {
                    //ouvrir la conexion
                    connexion.Open();

                    //Préparer la commande
                    string requete = "INSERT INTO t_question(enonce, multipleChoice, ordre, quizid)" + " VALUES ('{0}', {1}, {2}, {3})";
                    using (MySqlCommand commande = new MySqlCommand(requete, connexion))
                    {
                        //Format de la requete
                        commande.CommandText = string.Format(requete, nouvelleQuestion.Enonce.Replace("'", ("''")), nouvelleQuestion.EstChoixMultiple, nouvelleQuestion.Ordre, 1); ; /*TODO: quizid à remplacer BOUCHON TEMPORAIRE est 1 cara sur Mysql on a id=1*/
/*
                        //Exécuter la commande
                        //ExecuteNonQuery: insert/delete/update no se puede usar con un select
                        commande.ExecuteNonQuery();


                        //MYSQL
                        nouvelleQuestion.Id = (int)commande.LastInsertedId;
                        //nouvelleQuestion.Id = (int)commande.ExecuteScalar(); A VOIR PLUS TARD
                    }//Appele commande Dipose               
                } //Fermer la connexion
            }
            catch (Exception ex)
            {
                // TODO: faire quelque chose

            }
        }
*/
        public static void Update(Question2 questionMaj)
        {
            //Ouvrir la connexion
            string chaineDeConnexion = Properties.Settings.Default.ConnexionString;

            using (MySqlConnection connexion = new MySqlConnection(chaineDeConnexion)) //se pone using porque va a llamar automaticamente "dispose" asi que este se cerrara SOLO SIRVE SI TENEMOS EL DISPOSE EN NUESTRA VARIABLE
            {
                //ouvrir la conexion
                connexion.Open();

                //Préparer la commande
                string requete = "UPDATE t_question SET enonce = '{0}', multipleChoice = {1}, ordre = {2}, quizid={3} WHERE id={4} "; // es importante el WHERE porque nos permite decir que operacion queremos actualizar
                using (MySqlCommand commande = new MySqlCommand(requete, connexion))
                {
                    //Format de la requete
                    commande.CommandText = string.Format(requete, questionMaj.Enonce.Replace("'", ("''")), questionMaj.EstChoixMultiple, questionMaj.Ordre, questionMaj.Ordre, 1, questionMaj.Id); /*TODO: quizid à remplacer BOUCHON TEMPORAIRE est 1 cara sur Mysql on a id=1*/

                    //Exécuter la commande                        
                    commande.ExecuteNonQuery();

                }//Appele commande Dipose               
            } //Fermer la connexion


        }
    }
}
