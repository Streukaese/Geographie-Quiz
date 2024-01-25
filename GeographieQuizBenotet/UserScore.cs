using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographieQuizBenotet
{
    public class UserScore
    {
        
        public string Name { get; }
        public int Score { get; }
        public int Durchlaeufe { get; }
        public double Durschnitt { get; }
        public DateTime Datum { get; }
        public UserScore(string name, int score, int durchlaeufe, double durschnitt, DateTime datum)
        {
            Name = name;
            Score = score;
            Durchlaeufe = durchlaeufe;
            Durschnitt = durschnitt;
            Datum = datum;
        }
    }
}
