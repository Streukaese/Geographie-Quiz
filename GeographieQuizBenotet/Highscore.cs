using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeographieQuizBenotet
{
    public class Highscore
    {
        public List<UserScore> listeHighscores = new List<UserScore>();
        // zum aufurfen der Variablen score + durchläufe
        Quiz quiz = new Quiz();
        public Highscore()
        {

        }

        public void SpielerSpeichern(string playerName, int score, int durchlaeufe)
        {
            double durschnitt = score / durchlaeufe;
                                    // Lamda
            if(!listeHighscores.Any(p => p.Name == playerName))
            {
                UserScore newHighscoreEntry = new UserScore(playerName, score, durchlaeufe, durschnitt, DateTime.Now);  // Beispiel für fünf Werte
                listeHighscores.Add(newHighscoreEntry);
            }
            else
            {                                                   // Lamda
                UserScore savedUserScore = listeHighscores.Find(p => p.Name == playerName);
                savedUserScore.Score = score;
                savedUserScore.Durchlaeufe = durchlaeufe;
                savedUserScore.Durschnitt = durschnitt;
                savedUserScore.Datum = DateTime.Now;
            }
        }
        public List<UserScore> HighscoreLaden()
        {
            try
            {
                StreamReader reader = new StreamReader(new FileStream("Highscore.csv", FileMode.Open, FileAccess.Read), new UTF8Encoding());
                // Zum Überspringen des Header -> csv
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    string zeile = reader.ReadLine();
                    string[] teile = zeile.Split(';');
                    string name = teile[0];
                    int score = Int32.Parse(teile[1]);
                    int durchläufe = Int32.Parse(teile[2]);
                    double durschnitt = Double.Parse(teile[3]);
                    DateTime datum = DateTime.Parse(teile[4]);
                    
                    UserScore uS = new UserScore(name, score, durchläufe, durschnitt, datum);
                    listeHighscores.Add(uS);

                    listeHighscores.Sort();
                    while(listeHighscores.Count > 10)
                    {
                        listeHighscores.RemoveAt(listeHighscores.Count-1);
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ein Fehler ist aufgetreten: " + ex.Message);
            }

            return listeHighscores;
        }

        public void HighscoreSpeichern()
        {
                                                        // Lamda
            listeHighscores = listeHighscores.OrderBy(userScore =>  userScore.Durschnitt).ToList();
            try
            {
                StreamWriter writer = new StreamWriter(new FileStream("Highscore.csv", FileMode.Open, FileAccess.Write), new UTF8Encoding());
                writer.WriteLine("Name;Score;Durchläufe;Durschnitt;Datum");
                foreach (var item in listeHighscores)
                {                       // string literal
                    writer.WriteLine($"{item.Name};{item.Score};{item.Durchlaeufe};{item.Durschnitt};{item.Datum}");
                }
                writer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ein Fehler ist aufgetreten: " + ex.Message);
            }
        }
    }
}
