using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GeographieQuizBenotet
{
    public partial class Quiz : Form
    {
        Button[] buttons = new Button[4];
        public Quiz()
        {
            InitializeComponent();
            buttons[0] = buttonQuizAntwort1;
            buttons[1] = buttonQuizAntwort2;
            buttons[2] = buttonQuizAntwort3;
            buttons[3] = buttonQuizAntwort4;
        }
        int richtigeAntwort = 0;
        int aktuelleFrage = 0;
        public int score = 0;
        public int durchlaeufe = 0;
        int maxAnzahlFragen = 10;

        private int spielmodus;

        static Random zufallsquelle = new Random();
        Land richtig = null;
        public void SpielStarten(int spielmodus)
        {
            this.spielmodus = spielmodus;
            NaechsteFrage();
            Show();
        }
        private void NaechsteFrage()
        {
            if (spielmodus == 0)
            {
                QuizFragenFlagge();
            }
            else if (spielmodus == 1)
            {
                QuizFragenHauptstadt();
            }
            else if (spielmodus == 2)
            {
                QuizFragenLand();
            }
        }
        private void QuizFragenFlagge()
        {
            Antworten antwortGenerator = new Antworten(CsvOeffnen.laenderFragen);
            List<Land> auswahl = antwortGenerator.AntwortenGenerieren();

            // setzt die richtige Antwort
            richtig = auswahl[zufallsquelle.Next(4)];

            buttonQuizAntwort1.Text = auswahl[0].Name;
            buttonQuizAntwort1.BackgroundImage = null;
            buttonQuizAntwort1.Tag = auswahl[0];

            buttonQuizAntwort2.Text = auswahl[1].Name;
            buttonQuizAntwort2.BackgroundImage = null;
            buttonQuizAntwort2.Tag = auswahl[1];

            buttonQuizAntwort3.Text = auswahl[2].Name;
            buttonQuizAntwort3.BackgroundImage = null;
            buttonQuizAntwort3.Tag = auswahl[2];

            buttonQuizAntwort4.Text = auswahl[3].Name;
            buttonQuizAntwort4.BackgroundImage = null;
            buttonQuizAntwort4.Tag = auswahl[3];

            // aktualisiert den bildpfad für die richtige Antwort
            string bildPfad = $"../../../LaenderFlaggen/{richtig.Iso2Code}.png";
            pictureBoxQuizBild.Size = pictureBoxQuizBild.Size;
            pictureBoxQuizBild.Location = new System.Drawing.Point(126, 28);
            pictureBoxQuizBild.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxQuizBild.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxQuizBild.Image = Image.FromFile(bildPfad);

            // Elemente von QuizLand verstecken
            pictureBoxQuizBild.Visible = true;
            labelQuizLand.Visible = false;

            labelQuizFrage.Text = "Welchem Land ist die Flagge zuzuordnen?";
            labelQuizPunkte.Text = $"<Richtig {richtigeAntwort} von {aktuelleFrage}>\n" +
                               $"Punkte {score}\n" +
                               $"Durchlauf {durchlaeufe}";
        }
        private void QuizFragenHauptstadt()
        {
            Antworten antwortGenerator = new Antworten(CsvOeffnen.laenderFragen);
            List<Land> auswahl = antwortGenerator.AntwortenGenerieren();
            
            // setzt die richtige Antwort
            richtig = auswahl[zufallsquelle.Next(4)];

            buttonQuizAntwort1.Text = auswahl[0].Hauptstadt;
            buttonQuizAntwort1.BackgroundImage = null;
            buttonQuizAntwort1.Tag = auswahl[0];

            buttonQuizAntwort2.Text = auswahl[1].Hauptstadt;
            buttonQuizAntwort2.BackgroundImage = null;
            buttonQuizAntwort2.Tag = auswahl[1];

            buttonQuizAntwort3.Text = auswahl[2].Hauptstadt;
            buttonQuizAntwort3.BackgroundImage = null;
            buttonQuizAntwort3.Tag = auswahl[2];

            buttonQuizAntwort4.Text = auswahl[3].Hauptstadt;
            buttonQuizAntwort4.BackgroundImage = null;
            buttonQuizAntwort4.Tag = auswahl[3];

            // aktualisiert den bildpfad für die richtige Antwort
            string bildPfad = $"../../../LaenderFlaggen/{richtig.Iso2Code}.png";
            pictureBoxQuizBild.Size = pictureBoxQuizBild.Size;
            pictureBoxQuizBild.Location = new System.Drawing.Point(126, 28);
            pictureBoxQuizBild.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxQuizBild.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxQuizBild.Image = Image.FromFile(bildPfad);

            // Elemente von QuizLand verstecken
            pictureBoxQuizBild.Visible = true;
            labelQuizLand.Visible = false;

            labelQuizFrage.Text = "Welcher Hauptstadt ist die Flagge zuzuordnen?";
            labelQuizPunkte.Text = $"<Richtig {richtigeAntwort} von {aktuelleFrage}>\n" +
                               $"Punkte {score}\n" +
                               $"Durchlauf {durchlaeufe}";
        }
        private void QuizFragenLand()
        {
            Antworten antwortGenerator = new Antworten(CsvOeffnen.laenderFragen);
            List<Land> auswahl = antwortGenerator.AntwortenGenerieren();


            // setzt die richtige Antwort
            richtig = auswahl[zufallsquelle.Next(4)];

            // Setzen der Button-Texte und Tags
            buttonQuizAntwort1.Text = "";
            buttonQuizAntwort1.Tag = auswahl[0];
            buttonQuizAntwort1.BackgroundImage = Image.FromFile($"../../../LaenderFlaggen/{auswahl[0].Iso2Code}.png");
            buttonQuizAntwort1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            buttonQuizAntwort1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonQuizAntwort1.ForeColor = System.Drawing.Color.Transparent;

            buttonQuizAntwort2.Text = "";
            buttonQuizAntwort2.Tag = auswahl[1];
            buttonQuizAntwort2.BackgroundImage = Image.FromFile($"../../../LaenderFlaggen/{auswahl[1].Iso2Code}.png");
            buttonQuizAntwort2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            buttonQuizAntwort2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonQuizAntwort2.ForeColor = System.Drawing.Color.Transparent;

            buttonQuizAntwort3.Text = "";
            buttonQuizAntwort3.Tag = auswahl[2];
            buttonQuizAntwort3.BackgroundImage = Image.FromFile($"../../../LaenderFlaggen/{auswahl[2].Iso2Code}.png");
            buttonQuizAntwort3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            buttonQuizAntwort3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonQuizAntwort3.ForeColor = System.Drawing.Color.Transparent;

            buttonQuizAntwort4.Text = "";
            buttonQuizAntwort4.Tag = auswahl[3];
            buttonQuizAntwort4.BackgroundImage = Image.FromFile($"../../../LaenderFlaggen/{auswahl[3].Iso2Code}.png");
            buttonQuizAntwort4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            buttonQuizAntwort4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonQuizAntwort4.ForeColor = System.Drawing.Color.Transparent;

            // Versteckt Elemente der restlichen QuizAuswahl
            pictureBoxQuizBild.Visible = false;
            labelQuizFrage.Text = "Welchen Flaggen ist das Land zuzuordnen?";
            labelQuizLand.Visible = true;
            labelQuizLand.Text = richtig.Name;

            labelQuizPunkte.Text = $"<Richtig {richtigeAntwort} von {aktuelleFrage}>\n" +
                                           $"Punkte {score}\n" +
                                           $"Durchlauf {durchlaeufe}";
        }
        public void pruefeAntwortEvent_Click(object sender, EventArgs e)
        {
            // prüft ob fragen übrig sind
            if (aktuelleFrage < maxAnzahlFragen)
            {
                NaechsteFrage();
                aktuelleFrage++;
                // aktualisiert das Label mit Nummern
                labelQuizAnzeigeFrageNr.Text = $"Frage {aktuelleFrage} von {maxAnzahlFragen}";

                Button button = (Button)sender;
                if (button.Tag == richtig)
                {
                    score += 3;
                    richtigeAntwort++;
                }
                labelQuizPunkte.Text = $"<Richtig {richtigeAntwort} von {aktuelleFrage}>\n" +
                                           $"Punkte {score}\n" +
                                           $"Durchlauf {durchlaeufe}";
            }
            else
            {
                MessageBox.Show("Herzlichen Glückwunsch, das Quiz ist beendet!\n" +
                                "Speichern Sie den Highscore oder Spielen Sie\n" +
                                "                   eine weitere Runde!");
                Hide();
                aktuelleFrage = 0;
                richtigeAntwort = 0;
                labelQuizAnzeigeFrageNr.Text = "Frage 1 von 10";

                // setzt den Style der Button um - (Hier weil sonst 2 x schreiben(1 x pro Quiz))
                buttonQuizAntwort1.BackgroundImage = null;
                buttonQuizAntwort1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                buttonQuizAntwort1.FlatStyle = System.Windows.Forms.FlatStyle.System;
                buttonQuizAntwort1.ForeColor = Color.Black;

                buttonQuizAntwort2.BackgroundImage = null;
                buttonQuizAntwort2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                buttonQuizAntwort2.FlatStyle = System.Windows.Forms.FlatStyle.System;
                buttonQuizAntwort2.ForeColor = Color.Black;

                buttonQuizAntwort3.BackgroundImage = null;
                buttonQuizAntwort3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                buttonQuizAntwort3.FlatStyle = System.Windows.Forms.FlatStyle.System;
                buttonQuizAntwort3.ForeColor = Color.Black;

                buttonQuizAntwort4.BackgroundImage = null;
                buttonQuizAntwort4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                buttonQuizAntwort4.FlatStyle = System.Windows.Forms.FlatStyle.System;
                buttonQuizAntwort4.ForeColor = Color.Black;
            }
        }
    }
}