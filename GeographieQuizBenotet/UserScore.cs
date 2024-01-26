using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographieQuizBenotet
{
    public class UserScore : IComparable<UserScore>
    {
        
        public string Name { get; }
        public int Score { get; set; }
        public int Durchlaeufe { get; set; }
        public double Durschnitt { get; set; }
        public DateTime Datum { get; set; }
        public UserScore(string name, int score, int durchlaeufe, double durschnitt, DateTime datum)
        {
            Name = name;
            Score = score;
            Durchlaeufe = durchlaeufe;
            Durschnitt = durschnitt;
            Datum = datum;
        }

        public int CompareTo(UserScore other)
        {
            return -Durschnitt.CompareTo(other.Durschnitt);
        }
    }
}
