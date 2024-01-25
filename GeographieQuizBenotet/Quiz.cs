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
        //List<Land> 
        //public Button buttonQuizAntwort1;
        Button[] buttons = new Button[4];
        public Quiz()
        {
            InitializeComponent();
            buttons[0] = buttonQuizAntwort1;
            buttons[1] = buttonQuizAntwort2;
            buttons[2] = buttonQuizAntwort3;
            buttons[3] = buttonQuizAntwort4;
        }
        int richtigeAntwort = 1;
        int aktuelleFrage = 0;
        int score = 0;
        // TODO - Implementieren und zählen für HIGHSCORE
        int durchlaeufe = 0;
        //int richtigeFrage = 1;
        int maxAnzahlFragen = 10;

        //string land;
        //string kuerzel;
        int spielmodus;

        static Random zufallsquelle = new Random();
        void NaechsteFrage()
        {
            Antworten antwortGenerator = new Antworten(CsvOeffnen.laenderFragen);
            List<Land> auswahl = antwortGenerator.AntwortenGenerieren();

            Random random = new Random();
            int zufaelligerButton = random.Next(3);

            // setzt die richtige Antwort
            richtig = auswahl[zufallsquelle.Next(4)];

            buttonQuizAntwort1.Text = auswahl[0].Name;
            buttonQuizAntwort1.Tag = auswahl[0];

            buttonQuizAntwort2.Text = auswahl[1].Name;
            buttonQuizAntwort2.Tag = auswahl[1];

            buttonQuizAntwort3.Text = auswahl[2].Name;
            buttonQuizAntwort3.Tag = auswahl[2];

            buttonQuizAntwort4.Text = auswahl[3].Name;
            buttonQuizAntwort4.Tag = auswahl[3];

            buttons[zufaelligerButton].Text = richtig.Hauptstadt;
            buttons[zufaelligerButton].Tag = richtig;

            // Aktualisieren des Bildpfads für die richtige Antwort
            string bildPfad = $"../../../LaenderFlaggen/{richtig.Iso2Code}.png";
            pictureBoxQuizBild.Size = new System.Drawing.Size(420, 250);
            pictureBoxQuizBild.Location = new System.Drawing.Point(126, 28);
            pictureBoxQuizBild.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxQuizBild.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxQuizBild.Image = Image.FromFile(bildPfad);
        }
        public void QuizFragenFlagge(int spielmodus)
        {
            // TODO - Klasse + Funktion aufrufen || Doesnt work
            //Test Auslagerung 1
            Antworten antwortGenerator = new Antworten(CsvOeffnen.laenderFragen);
            List<Land> auswahl = antwortGenerator.AntwortenGenerieren();

            // Mischen der ausgewählten Länder (inklusive der richtigen Antwort)
            //auswahl = auswahl.OrderBy(x => zufallsquelle.Next()).ToList();
            Random random = new Random();
            int zufaelligerButton = random.Next(3);

            // setzt die richtige Antwort
            richtig = auswahl[zufallsquelle.Next(4)];

            buttonQuizAntwort1.Text = auswahl[0].Name;
            buttonQuizAntwort1.Tag = auswahl[0];

            buttonQuizAntwort2.Text = auswahl[1].Name;
            buttonQuizAntwort2.Tag = auswahl[1];

            buttonQuizAntwort3.Text = auswahl[2].Name;
            buttonQuizAntwort3.Tag = auswahl[2];

            buttonQuizAntwort4.Text = auswahl[3].Name;
            buttonQuizAntwort4.Tag = auswahl[3];

            buttons[zufaelligerButton].Text = richtig.Hauptstadt;
            buttons[zufaelligerButton].Tag = richtig;

            // Aktualisieren des Bildpfads für die richtige Antwort
            string bildPfad = $"../../../LaenderFlaggen/{richtig.Iso2Code}.png";
            pictureBoxQuizBild.Size = pictureBoxQuizBild.Size;  //new System.Drawing.Size(405, 242);
            // Test - Size PictureBox
            //MessageBox.Show($"picturebox.size {pictureBoxQuizBild.Size.Width}x {pictureBoxQuizBild.Size.Height}y");
            pictureBoxQuizBild.Location = new System.Drawing.Point(126, 28);
            pictureBoxQuizBild.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxQuizBild.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxQuizBild.Image = Image.FromFile(bildPfad);

            labelQuizFrage.Text = "Welchem Land ist die Flagge zuzuordnen?";
            labelQuizPunkte.Text = $"<Richtig {richtigeAntwort} von {aktuelleFrage}>\n" +
                                       $"Punkte {score}";

            //aktuelleFrage++;
            //if (aktuelleFrage < maxAnzahlFragen)
            //{
            //    // TODO - Quiz muss zuerst bei ButtonClick weiter gehen bevor getestet wird - DONE
            //    labelQuizAnzeigeFrageNr.Text = "Frage " + "<b>" + aktuelleFrage + "</b>" + " von 10";
            //    labelQuizAnzeigeFrageNr.Font = new Font(labelQuizAnzeigeFrageNr.Font, FontStyle.Regular); // Setze auf FontStyle.Regular, um das Fettschriftattribut für den restlichen Text zu entfernen
            //    labelQuizAnzeigeFrageNr.UseCompatibleTextRendering = true; // Aktiviere die HTML-Rendering-Funktion für das Label
            //}
            //else
            //{
            //    // TODO - if else(pkt >= Highscore) {AddHighscore}
            //    this.Close();
            //}

            //---------------------------------------------------------------------------------------------
        }
        public void QuizFragenHauptstadt(int qnum)
        {
            //Test Auslagerung 1
            Antworten antwortGenerator = new Antworten(CsvOeffnen.laenderFragen);
            List<Land> auswahl = antwortGenerator.AntwortenGenerieren();

            // Mischen der ausgewählten Länder (inklusive der richtigen Antwort)
            //auswahl = auswahl.OrderBy(x => zufallsquelle.Next()).ToList();
            Random random = new Random();
            int zufaelligerButton = random.Next(3);

            // setzt die richtige Antwort
            richtig = auswahl[zufallsquelle.Next(4)];

            buttonQuizAntwort1.Text = auswahl[0].Hauptstadt;
            buttonQuizAntwort1.Tag = auswahl[0];

            buttonQuizAntwort2.Text = auswahl[1].Hauptstadt;
            buttonQuizAntwort2.Tag = auswahl[1];

            buttonQuizAntwort3.Text = auswahl[2].Hauptstadt;
            buttonQuizAntwort3.Tag = auswahl[2];

            buttonQuizAntwort4.Text = auswahl[3].Hauptstadt;
            buttonQuizAntwort4.Tag = auswahl[3];

            buttons[zufaelligerButton].Text = richtig.Hauptstadt;
            buttons[zufaelligerButton].Tag = richtig;

            // Aktualisieren des Bildpfads für die richtige Antwort
            string bildPfad = $"../../../LaenderFlaggen/{richtig.Iso2Code}.png";
            pictureBoxQuizBild.Size = new System.Drawing.Size(420, 250);
            pictureBoxQuizBild.Location = new System.Drawing.Point(126, 28);
            pictureBoxQuizBild.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxQuizBild.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxQuizBild.Image = Image.FromFile(bildPfad);
            
            labelQuizFrage.Text = "Welcher Hauptstadt ist die Flagge zuzuordnen?";
            labelQuizPunkte.Text = $"<Richtig {richtigeAntwort} von {aktuelleFrage}>\n" +
                                       $"Punkte {score}";
        }
        public void QuizFragenLand(int qnum)
        {
            //Test Auslagerung 1
            Antworten antwortGenerator = new Antworten(CsvOeffnen.laenderFragen);
            List<Land> auswahl = antwortGenerator.AntwortenGenerieren();

            // Mischen der ausgewählten Länder (inklusive der richtigen Antwort)
            //auswahl = auswahl.OrderBy(x => zufallsquelle.Next()).ToList();

            Random random = new Random();
            int zufaelligerButton = random.Next(3);

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

            buttons[zufaelligerButton].Text = richtig.Hauptstadt;
            buttons[zufaelligerButton].Tag = richtig;
            buttons[zufaelligerButton].BackgroundImage = Image.FromFile($"../../../LaenderFlaggen/{auswahl[3].Iso2Code}.png");

            pictureBoxQuizBild.Visible = false;
            labelQuizFrage.Text = "Welchen Flaggen ist das Land zuzuordnen?";
            labelQuizLand.Visible = true;
            labelQuizLand.Text = richtig.Name;

            labelQuizPunkte.Text = $"<Richtig {richtigeAntwort} von {aktuelleFrage}>\n" +
                                       $"Punkte {score}";
        }
        private void Quiz_Load(object sender, EventArgs e)
        {
            // TODO - Unterschiedliche Quiz an die Button anbinden, Wie? If else?
            //pruefeAntwortEvent_Click(sender, e);

            // Wird nicht benötigt !?
            //foreach (Land l in laenderFragen)
            //{
            //    listBoxBuecher.Items.Add(l.ToString());
            //}
        }

        Land richtig = null;
        public void pruefeAntwortEvent_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(button.Text);
            // TODO - Quiz weiterführen wenn geklickt wird
            // Index "x" erhöhen

            // Überprüft ob fragen übrig sind.
            if (aktuelleFrage < maxAnzahlFragen)
            {
                NaechsteFrage();

                // Aktualisiere das Label mit dem Fragenzähler
                labelQuizAnzeigeFrageNr.Text = $"Frage {aktuelleFrage} von {maxAnzahlFragen}";

                aktuelleFrage++;
                Button button = (Button)sender;
                if (button.Tag == richtig)
                {
                    score += 3;
                    richtigeAntwort++;
                }
                labelQuizPunkte.Text = $"<Richtig {richtigeAntwort} von {aktuelleFrage}>\n" +
                                           $"Punkte {score}";
            }
            else
            {
                // Beendet das Quiz
                MessageBox.Show("Herzlichen Glückwunsch, das Quiz ist beendet!");
                Hide();
                aktuelleFrage = 0;
                richtigeAntwort = 0;
                labelQuizAnzeigeFrageNr.Text = "Frage 1 von 10";
                buttonQuizAntwort4.BackgroundImage = null;
                buttonQuizAntwort4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                buttonQuizAntwort4.FlatStyle = System.Windows.Forms.FlatStyle.System;
                buttonQuizAntwort4.ForeColor = Color.Black;
            }


                //CsvOeffnen.laenderFragen[zufallsquelle.Next(CsvOeffnen.laenderFragen.Count)];

            // Öffnet ausgelagerte Funktion
            //CsvOeffnen.CsvLesen();

            //List<Land> auswahl = new List<Land>();
            //while (auswahl.Count < 4)
            //{
            //    Land l = CsvOeffnen.laenderFragen[zufallsquelle.Next(CsvOeffnen.laenderFragen.Count)];
            //    if (!auswahl.Contains(l))
            //    {   
            //        auswahl.Add(l);
            //    }
            //}

            //Test auslagerung
            //AntwortGenerator antwortGenerator = new AntwortGenerator(CsvOeffnen.laenderFragen);
            //List<Land> auswahl = antwortGenerator.GeneriereAntworten();

            //// Mischen der ausgewählten Länder (inklusive der richtigen Antwort)
            ////auswahl = auswahl.OrderBy(x => zufallsquelle.Next()).ToList();

            //// Setzen der Button-Texte und Tags
            //for (int i = 0; i < 4; ++i)
            //{
            //    buttonQuizAntwort1.Text = auswahl[0].Name;
            //    buttonQuizAntwort1.Tag = auswahl[0];

            //    buttonQuizAntwort2.Text = auswahl[1].Name;
            //    buttonQuizAntwort2.Tag = auswahl[1];

            //    buttonQuizAntwort3.Text = auswahl[2].Name;
            //    buttonQuizAntwort3.Tag = auswahl[2];

            //    buttonQuizAntwort4.Text = auswahl[3].Name;
            //    buttonQuizAntwort4.Tag = auswahl[3];
            //}

            ////// setzt die richtige Antwort
            //richtig = auswahl[zufallsquelle.Next(4)];

            //// Aktualisieren des Bildpfads für die richtige Antwort
            //string bildPfad = $"../../../LaenderFlaggen/{richtig.Iso2Code}.png";
            //pictureBoxQuizBild.Size = new System.Drawing.Size(420, 250);
            //pictureBoxQuizBild.Location = new System.Drawing.Point(126, 28);
            //pictureBoxQuizBild.BorderStyle = BorderStyle.Fixed3D;
            //pictureBoxQuizBild.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureBoxQuizBild.Image = Image.FromFile(bildPfad);
        }
    }
}