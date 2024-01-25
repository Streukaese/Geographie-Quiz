using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographieQuizBenotet
{
    public class Land
    {
        public string Name { get; }
        public string Hauptstadt { get; }
        public string Bilddatei { get; }
        public string Iso3Code { get; }
        public string Iso2Code { get; }
        public Land(string name, string hauptstadt, string bilddatei, string iso3Code, string iso2Code)
        {
            Name = name;
            Hauptstadt = hauptstadt;
            Bilddatei = bilddatei;
            Iso3Code = iso3Code;
            Iso2Code = iso2Code;
        }
    }
}
