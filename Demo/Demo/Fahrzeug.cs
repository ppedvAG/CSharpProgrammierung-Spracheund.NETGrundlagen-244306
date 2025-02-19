

namespace Demo
{
    public abstract class Fahrzeug
    {

        // Eigenschaften
        private string farbe;
        private string treibstoff;
        private int geschwindigkeit;
        private bool motorLäuft;

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
            this.geschwindigkeit = geschwindigkeit;

            // erhöht die Anzahl der erzeugten Fahrzeuge 
            // wird im statischen feld anzahDerErzeugtenFahrzeuge gespeichert
            anzahlDerErzeugtenFahrzeuge++;
        }

        // Get Mehtoden zu den Eigenschaften
        public string GetFarbe()
        {
            return this.farbe;
        }
        public string GetTreibstoff()
        {
            return this.treibstoff;
        }
        public int GetGeschwindigkeit()
        {
            return this.geschwindigkeit;
        }
        public bool GetMotorLäuft()
        {
            return this.motorLäuft;
        }

        // Set Mehtoden zu den Eigenschaften
        public void SetFarbe(string farbe)
        {
            this.farbe = farbe;
        }
        public void SetTreibstoff(string treibstoff)
        {
            this.treibstoff = treibstoff;
        }
        public void SetFarbe(int geschwindigkeit)
        {
            this.geschwindigkeit = geschwindigkeit;
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
