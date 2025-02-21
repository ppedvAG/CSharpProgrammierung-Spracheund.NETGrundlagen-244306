using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    // Klasse Auto erbt von der Klasse Fahrzeug
    public class PKW : Fahrzeug
    {
        // die Eigenschaften der Basisklasse Fahrzeug werden übernommen
        // neue Eigenschaft AnzahlTüren
        public int AnzahlTüren { get; set; }


        // leerer Konstruktor der Klasse Auto
        public PKW(): base() // Basis Konstruktor wird aufgerufen
        {
            AnzahlTüren = 0;
        }


        // Konstruktor mit Parametern der Klasse Auto
        public PKW(string farbe, string treibstoff, int geschwindigkeit, int anzahlTüren) : base(farbe, treibstoff, geschwindigkeit) // Basis Konstruktor wird aufgerufen
        {
            this.AnzahlTüren = anzahlTüren;
        }


        // Methode Info wird überschrieben
        public override sealed void Info() //Methode Info wird versiegelt (von Auto abgeleitete Klassen können nicht mehr überschreiben)
        {
            Console.WriteLine("Ich bin ein Auto");
        }

        // Methode Hupen wir überschrieben
        public override void Hupen()
        {
            Console.WriteLine("Auto Hupt!");
        }
    }
}
