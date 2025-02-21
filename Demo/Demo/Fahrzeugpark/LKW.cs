using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Fahrzeugpark
{
    // Klasse Auto erbt von der Klasse Fahrzeug
    public class LKW : Fahrzeug, IBeladbar
    {
        // die Eigenschaften der Basisklasse Fahrzeug werden übernommen
        // neue Eigenschaft AnzahlTüren
        public int AnzahlTüren { get; set; }


        // Eigenschaft BeladenesFahrzeug
        public Fahrzeug BeladenesFahrzeug { get; set; }


        // leerer Konstruktor der Klasse Auto
        public LKW() : base() // Basis Konstruktor wird aufgerufen
        {
            AnzahlTüren = 0;
        }


        // Konstruktor mit Parametern der Klasse Auto
        public LKW(string farbe, string treibstoff, int geschwindigkeit, int anzahlTüren) : base(farbe, treibstoff, geschwindigkeit) // Basis Konstruktor wird aufgerufen
        {
            AnzahlTüren = anzahlTüren;
        }


        // Methode Info wird überschrieben
        public override sealed void Info() //Methode Info wird versiegelt (von Auto abgeleitete Klassen können nicht mehr überschreiben)
        {
            Console.WriteLine("Ich bin ein LKW");
        }

        // Methode Hupen wir überschrieben
        public override void Hupen()
        {
            Console.WriteLine("LKW Hupt!");
        }

        // Funktion zum Beladen eines Fahrzeugs
        public void Beladen(Fahrzeug fahrzeug)
        {
            if (BeladenesFahrzeug == null)
            {
                BeladenesFahrzeug = fahrzeug;
            }
            else
            {
                Console.WriteLine("LKW ist bereits beladen");
            }
        }

        // Funktion zum Entladen eines Fahrzeugs
        public Fahrzeug Entladen()
        {
            if (BeladenesFahrzeug != null)
            {
                Fahrzeug beladenesFahrzeugTemp = BeladenesFahrzeug;
                BeladenesFahrzeug = null;
                return beladenesFahrzeugTemp;
            }
            else
            {
                Console.WriteLine("LKW ist nicht beladen");
                return null;
            }
        }
    }
}
