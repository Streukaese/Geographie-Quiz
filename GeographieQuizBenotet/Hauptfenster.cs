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
        private CsvOeffnen csvOeffnen = new CsvOeffnen();
        public Hauptfenster()
        {
            InitializeComponent();
            quizForm = new Quiz();
        }
        // Funktion um quiz in 2.tes Form zu öffnen?
        public void QuizBeginnt()
        {
            if (radioButtonFlagge.Checked || radioButtonHauptstadt.Checked || radioButtonLaender.Checked)
            {
                //Quiz quiz = new Quiz();

                if (radioButtonFlagge.Checked == true)
                {
                    quizForm.SpielStarten(0);
                    //pruefeAntwortEvent_Click(sender, e);
                }
                else if (radioButtonHauptstadt.Checked == true)
                {
                    quizForm.SpielStarten(1);
                }
                else if (radioButtonLaender.Checked == true)    // && textBoxLoginName.TextLength <= 0
                {
                    quizForm.SpielStarten(2);
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

            //// Setze den Spaltennamen und die Sortierreihenfolge
            //string columnName = "Durschnitt"; // Der Name der Spalte, nach der sortiert werden soll
            //ListSortDirection sortDirection = ListSortDirection.Ascending; // Sortierreihenfolge


            //// Überprüfe, ob die angegebene Spalte existiert
            //if (dataGridViewHighscore.Columns.Contains(columnName))
            //{
            //    // Sortiere die DataGridView
            //    dataGridViewHighscore.Sort(dataGridViewHighscore.Columns[columnName], sortDirection);
            //}
            //else
            //{
            //    // Warn Meldung
            //    MessageBox.Show("Spalte nicht gefunden: " + columnName);
            //}
            //dataGridViewHighscore.DataSource = new BindingList <UserScore>(highscore.listeHighscores);
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