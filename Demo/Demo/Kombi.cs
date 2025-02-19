using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    // Klasse Kombi erbt von der Klasse Auto
    internal class Kombi: Auto
    {
        // leerer Konstruktor der Klasse Kombi
        public Kombi() : base() // Basis Konstruktor wird aufgerufen
        {

        }

        // Info Methode kann nicht überschrieben werden, da sie versiegelt ist

        /*public override void Info()
        {
            Console.WriteLine("Ich bin ein Kombi");
        }*/
    }
}
