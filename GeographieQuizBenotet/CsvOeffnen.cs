using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeographieQuizBenotet
{
    public class CsvOeffnen
    {
        public static List<Land> laenderFragen = new List<Land>();
        public static void CsvLesen()
        {
            try
            {
                StreamReader reader = new StreamReader(new FileStream("LänderListeProjekt.csv", FileMode.Open, FileAccess.Read), new UTF8Encoding());
                while (!reader.EndOfStream)
                {
                    string zeile = reader.ReadLine();
                    // Etwas mit der Zeile machen (Split(';');
                    String[] teile = zeile.Split(';');
                    string name = teile[0];
                    string hauptstadt = teile[1];
                    string bilddatei = teile[2];
                    string iso3Code = teile[3];
                    string iso2Code = teile[4];

                    Land l = new Land(name, hauptstadt, bilddatei, iso3Code, iso2Code);
                    laenderFragen.Add(l); 
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ein Fehler ist aufgetreten: " + ex.Message);
            }
        }
    }
}
