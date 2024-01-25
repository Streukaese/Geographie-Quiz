using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeographieQuizBenotet
{
    public partial class Hauptfenster : Form
    {
        private Quiz quizForm;   
        public Hauptfenster()
        {
            InitializeComponent();
            quizForm = new Quiz();
        }
        // Funktion um quiz in 2.tes Form zu öffnen?
        void QuizBeginnt()
        {
            if (radioButtonFlagge.Checked || radioButtonHauptstadt.Checked || radioButtonLaender.Checked)
            {
                //Quiz quiz = new Quiz();

                if (radioButtonFlagge.Checked == true)
                {
                    quizForm.QuizFragenFlagge(qnum);
                    quizForm.Show();
                    //pruefeAntwortEvent_Click(sender, e);
                }
                else if (radioButtonHauptstadt.Checked == true)
                {
                    quizForm.QuizFragenHauptstadt(qnum);
                    quizForm.Show();
                }
                else if (radioButtonLaender.Checked == true)
                {
                    quizForm.QuizFragenLand(qnum);
                    quizForm.Show();
                }
                // Muss auskommentiert werden -> Fehler
                //quizForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie eine Kategorie aus", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        int qnum = 0;
        private void buttonAuswahlSpielen_Click(object sender, EventArgs e)
        {
            QuizBeginnt();
            //if (radioButtonFlagge.Checked || radioButtonHauptstadt.Checked || radioButtonLaender.Checked)
            //{
            //    Quiz quiz = new Quiz();

            //    if (radioButtonFlagge.Checked == true)
            //    {
            //        quiz.QuizFragenFlagge(qnum);
            //        //pruefeAntwortEvent_Click(sender, e);

            //    }
            //    else if (radioButtonHauptstadt.Checked == true)
            //    {
            //        quiz.QuizFragenHauptstadt(qnum);
            //    }
            //    else if (radioButtonLaender.Checked == true)
            //    {
            //        quiz.QuizFragenLand(qnum);
            //    }
            //    quiz.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("Bitte wählen Sie eine Kategorie aus", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void textBoxLoginName_Click(object sender, EventArgs e)
        {
            textBoxLoginName.Text = "";
        }
        private void textBoxLoginPasswort_Click(object sender, EventArgs e)
        {
            textBoxLoginPasswort.Text = "";
        }

        private void Hauptfenster_Load(object sender, EventArgs e)
        {
            Highscore highscore = new Highscore();
            highscore.HighscoreLaden();
        }

        private void buttonHighscoreSpeichern_Click(object sender, EventArgs e)
        {
            Highscore HighscoreSpeichern = new Highscore();
            HighscoreSpeichern.ZuCsvSchreiben();
        }
    }
}