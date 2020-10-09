using QUIZ.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZ
{
    public partial class EcranPrincipal : Form
    {
        private List<Question2> questions;
        private Question2 selected;
        public EcranPrincipal()
        {

            InitializeComponent();  
    }


            

        private void CmbMenuQuiz_SelectedIndexChanged(object sender, EventArgs e)
        {
           // for (int i=0; i<3; i++)
           // {
                 CmbMenuQuiz.Text = selected.Enonce;
                //selected.Enonce = textBox1.Text
           // }


        }

        private void EcranPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
