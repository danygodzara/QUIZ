using QUIZ;
using QUIZ.DataAccess;
using Quiz_TP.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_TP
{
    public partial class FrmEcranPrincipal : Form
    {
        private List<Quiz> quiz;
        private Quiz selectedQuiz;
        private int nomQuiz;

        private List<Question> questions;
        private Question selectedQues;
        private int nomQues;


        private List<Reponses> reponses;
        private Reponses selectedRep;
        private int nomRep;

        int i = 1;
        public FrmEcranPrincipal()
        {
            InitializeComponent();
            CmbMenuQuiz.DisplayMember = "Title";
            quiz = QuizDAO.FindAll();
            CmbMenuQuiz.DataSource = quiz;
            selectedQuiz = quiz[0];
            nomQuiz = selectedQuiz.Id;

        }


        private void BtnDemarrer_Click(object sender, EventArgs e)
        {
            questions = QuestionDAO.FindAll(nomQuiz);
            selectedQues = questions[0];
            GboxQuestion.Text = selectedQues.ToString();
            nomQues = selectedQues.Id;

            reponses = ReponseDAO.FindAll(nomQues);
            selectedRep = reponses[0];
            BtnDemarrer.Enabled = false;

            if (selectedQues.EstChoixMultiple == false)
            {
                CheckBox ChBoxReponse = new CheckBox
                {
                    Location = new Point(25, 51),
                    Name = "Rep" + selectedRep.Text, // + ++nbNouveauxBouton,
                    Size = new Size(102, 20),
                    //TabIndex = dernierTabIndex++,
                    Text = selectedRep.Text,
                    Visible = true

                };
            }


        }

        private void BtnSuivante_Click(object sender, EventArgs e)
        {
            
            if(questions[i].Enonce != null)
            {
                selectedQues = questions[i];
                GboxQuestion.Text = selectedQues.ToString();
                i++;
            }
            else
            {
                BtnDemarrer.Enabled = true;
            }
              
            
            
        }

        private void GboxQuestion_Enter(object sender, EventArgs e)
        {
            

        }

        private void FrmEcranPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
