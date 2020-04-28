using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniParduotuve
{
    class Preke
    {
        public string Pavadinimas { get; }
        public double Kaina { get; }
        public double DezPlotis { get; }
        public double DezIlgis { get; }
        public double DezAukstis { get; }

        public Preke(string pavadinimas, double kaina, double dezPlotis, double dezIlgis, double dezAukstis)
        {
            Pavadinimas = pavadinimas;
            Kaina = kaina;
            DezPlotis = dezPlotis;
            DezIlgis = dezIlgis;
            DezAukstis = dezAukstis;
        }
    }
}
