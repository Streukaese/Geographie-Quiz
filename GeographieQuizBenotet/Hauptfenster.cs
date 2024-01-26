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
        Highscore highscore = new Highscore();
        public Hauptfenster()
        {
            InitializeComponent();
            quizForm = new Quiz();
        }
        public void QuizBeginnt()
        {
            if (radioButtonFlagge.Checked || radioButtonHauptstadt.Checked || radioButtonLaender.Checked)
            {
                if (radioButtonFlagge.Checked == true)
                {
                    quizForm.SpielStarten(0);
                }
                else if (radioButtonHauptstadt.Checked == true)
                {
                    quizForm.SpielStarten(1);
                }
                else if (radioButtonLaender.Checked == true)
                {
                    quizForm.SpielStarten(2);
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie eine Kategorie aus", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonAuswahlSpielen_Click(object sender, EventArgs e)
        {
            quizForm.durchlaeufe++;
            string playerName = textBoxLoginName.Text;

            if (playerName.Length == 0)
            {
                MessageBox.Show("Namen eingeben!", "Hinweis!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxLoginName.Focus();
                return;
            }
            else
            {
                QuizBeginnt();
            }
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
            dataGridViewHighscore.DataSource = new BindingList<UserScore>(highscore.HighscoreLaden());
        }
        private void buttonHighscoreSpeichern_Click(object sender, EventArgs e)
        {
            int score = quizForm.score;
            if (score != 0)
            {
                string playerName = textBoxLoginName.Text;
                int durchlaeufe = quizForm.durchlaeufe;
                highscore.SpielerSpeichern(playerName, score, durchlaeufe);
                highscore.HighscoreSpeichern();

                // dgv aktualisieren
                dataGridViewHighscore.DataSource = null;
                dataGridViewHighscore.DataSource = highscore.listeHighscores;
                dataGridViewHighscore.Refresh();
            }
            else
            {
                MessageBox.Show("Sie haben keine Punkte zum Speichern!", "Hinweis!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}