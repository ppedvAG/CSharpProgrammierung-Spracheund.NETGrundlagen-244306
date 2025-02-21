

namespace Demo
{
    public abstract class Fahrzeug
    {

        //statisches Feld für Zufallsgenerator
        protected static Random generator = new Random();
        //Methode zur zufälligen Generierung eines Fahrzeugs
      

        // Eigenschaften
        /*private string farbe;
        private string treibstoff;
        private int geschwindigkeit;
        private bool motorLäuft;*/
        public string farbe { get; set; }
        public string treibstoff { get; set; }
        public int geschwindigkeit { get; set; }
        public bool motorLäuft { get; set; }

        // zählt wie viele Objekte der Klasse Fahrzeug erzeugt wurden
        public static int anzahlDerErzeugtenFahrzeuge = 0;

        //Konstruktor
        public Fahrzeug()
        {
            this.geschwindigkeit = 0;
            this.farbe = "";
            this.treibstoff = "";
            anzahlDerErzeugtenFahrzeuge++;
        }

        // Konstruktor mit Parametern
        public Fahrzeug(string farbe, string treibstoff, int geschwindigkeit)
        {
            this.farbe = farbe;
            this.treibstoff = treibstoff;
            if(geschwindigkeit < 0)
            {
                throw new SpeedUnderZeroException();
            }
            this.geschwindigkeit = geschwindigkeit;

            // erhöht die Anzahl der erzeugten Fahrzeuge 
            // wird im statischen feld anzahDerErzeugtenFahrzeuge gespeichert
            anzahlDerErzeugtenFahrzeuge++;
        }

        
        


        // Methode zum Beschleunigen
        public int Beschleunige(int geschwindigkeit)
        {
            this.geschwindigkeit += geschwindigkeit;
            return this.geschwindigkeit;
        }

        // Methode zum Starten des Motors
        public void StarteMotor()
        {
            this.motorLäuft = true;
        }

        // Methode zum stoppen des Motors
        public bool StoppeMotor()
        {
            if(this.geschwindigkeit == 0)
            {
                this.motorLäuft = false;
                
            }
            return this.motorLäuft;
        }

        // Methode Info ausgeben
        // ist virtual und kann deswegen überschrieben werden
        public virtual void Info()
        {
            Console.WriteLine("Ich bin ein Fahrzeug");
        }

        // abstrakte Methode Hupen
        public abstract void Hupen();

    }
}
