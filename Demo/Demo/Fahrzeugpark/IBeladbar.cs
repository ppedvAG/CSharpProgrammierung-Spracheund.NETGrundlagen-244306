using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Fahrzeugpark
{
    // Interface IBeladbar
    internal interface IBeladbar
    {
        // Eigenschaft BeladenesFahrzeug
        public Fahrzeug BeladenesFahrzeug { get; set; }

        // Funktion zum Beladen eines Fahrzeugs
        public void Beladen(Fahrzeug fahrzeug);

        // Funktion zum Entladen eines Fahrzeugs
        public Fahrzeug Entladen();
    }
}
