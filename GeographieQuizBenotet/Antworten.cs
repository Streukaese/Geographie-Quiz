using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographieQuizBenotet
{
    public class Antworten
    {
        private Random zufallsquelle;
        public Antworten(List<Land> laenderFragen)
        {
            CsvOeffnen.laenderFragen = laenderFragen;
            zufallsquelle = new Random();
        }
        public List<Land> AntwortenGenerieren()
        {
            CsvOeffnen.CsvLesen();

            List<Land> auswahl = new List<Land>();
            while (auswahl.Count < 4)
            {
                Land l = CsvOeffnen.laenderFragen[zufallsquelle.Next(CsvOeffnen.laenderFragen.Count)];
                if (!auswahl.Contains(l))
                {
                    auswahl.Add(l);
                }
            }
            return auswahl;
        }
    }
}
