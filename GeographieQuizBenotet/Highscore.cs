using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeographieQuizBenotet
{
    internal class Highscore
    {
        public static List<UserScore> listeHighscores = new List<UserScore>();
        // zum aufurfen der Variablen score + durchläufe
        Quiz quiz = new Quiz();
        public Highscore()
        {

        }

        public void HighscoreLaden()
        {
            // TODO - SteamReader zum SteamWriter ändern
            try
            {
                StreamReader reader = new StreamReader(new FileStream("Highscore.csv", FileMode.Open, FileAccess.Read), new UTF8Encoding());
                while (!reader.EndOfStream)
                {
                    string zeile = reader.ReadLine();
                    // Etwas mit der Zeile machen (Split(';');
                    String[] teile = zeile.Split(';');
                    string name = teile[0];
                    int score = Int32.Parse(teile[1]);
                    int durchläufe = int.Parse(teile[2]);
                    double durschnitt = Double.Parse(teile[3]);
                    DateTime datum = DateTime.Parse(teile[4]);
                    
                    UserScore uS = new UserScore(name, score, durchläufe, durschnitt, datum);
                    listeHighscores.Add(uS);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ein Fehler ist aufgetreten: " + ex.Message);
            }
        }
        public String ZuCsvSchreiben()        // String oder Void
        {
            string name = "";
            int score = 0;
            int durchlaeufe = 0;
            double durschnitt = 0;
            DateTime datum = DateTime.Now;
            UserScore u = new UserScore(name, score, durchlaeufe, durschnitt, datum);
            name = u.Name;
            score = u.Score;
            durchlaeufe = u.Durchlaeufe;
            durschnitt = u.Durschnitt;
            datum = u.Datum;
            return $"{name}, {score}, {durchlaeufe}, {durschnitt}, {datum}";
        }
        public void HighscoreSpeichern()
        {
            //// TODO - SteamReader zum SteamWriter ändern
            //try
            //{
            //    StreamWriter writer = new StreamWriter(new FileStream("Highscore.csv", FileMode.Open, FileAccess.Write), new UTF8Encoding());
            //    while(writer.)
            //    {

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Ein Fehler ist aufgetreten: " + ex.Message);
            //}


            //// TODO - SteamReader zum SteamWriter ändern
            //try
            //{
            //    StreamReader reader = new StreamReader(new FileStream("Highscore.csv", FileMode.Open, FileAccess.Read), new UTF8Encoding());
            //    while (!reader.EndOfStream)
            //    {
            //        string zeile = reader.ReadLine();
            //        // Etwas mit der Zeile machen (Split(';');
            //        String[] teile = zeile.Split(';');
            //        string name = teile[0];
            //          // TODO - score aus quiz übernehmen
            //        int score = Int32.Parse(teile[1]);
            //          // TODO - durchläufe aus quiz übernehmen
            //        int durchläufe = int.Parse(teile[2]);
            //        double durschnitt = Double.Parse(teile[3]);
            //        DateTime datum = DateTime.Parse(teile[4]);

            //        UserScore uS = new UserScore(name, score, durchläufe, durschnitt, datum);
            //        listeHighscores.Add(uS);
            //    }
            //    reader.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Ein Fehler ist aufgetreten: " + ex.Message);
            //}
        }
    }
}
