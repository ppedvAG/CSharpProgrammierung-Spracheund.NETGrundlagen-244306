





using Demo;

class Program
{
    static void Main(string[] args)
    {

        Fahrzeug fahrzeug = new Auto("blau", "Benzin", 180, 5);
        Auto auto = new Auto("blau", "Benzin", 180, 2);
        Auto kombi = new Kombi();
        kombi.Beschleunige(10);

        Fahrzeug[] fahrzeuge = new Fahrzeug[3];
        fahrzeuge[0] = fahrzeug;
        fahrzeuge[1] = auto;
        fahrzeuge[2] = kombi;

        int summeGeschwindigkeit = 0;
        for (int i = 0;i<3;i++) {
            summeGeschwindigkeit+= ((Fahrzeug)fahrzeuge[i]).GetGeschwindigkeit();
        }
        System.Console.WriteLine(summeGeschwindigkeit/3);


        fahrzeug.Hupen();
        auto.Hupen();
        kombi.Hupen();
    }
        /*
        Fahrzeug fahrzeug = new Fahrzeug("Rot", "Benzin", 180);
        Auto auto = new Auto("Rot", "Benzin", 180, 5);
        fahrzeug.Info(); // Aufruf der Info Methode von der Basisklasse
        auto.Info(); // Aufruf der überschriebenen Info Methode der abgeleiteten Klasse

        // Methode Addieren wird aufgerufen
        int Ergebnis = Addieren(5, 3);
        // Ergebnis wird ausgegeben
        Console.WriteLine(Ergebnis);
        Console.ReadKey();


        // neue Variable Nummer wird der Wert 5 zugewiesen
        int Nummer;
        Nummer = 5;
        // Variable Nummer wird ausgegeben
        Console.WriteLine(Nummer);
        //Variable Nummer wird um 3 erhöht
        Nummer = Nummer + 3;
        // Variable Nummer wird ausgegeben
        Console.WriteLine(Nummer);


        // String mit + verknüpfen
        string Text = "Die Zahl ist: " + Nummer + " und das wars";
        Console.WriteLine(Text);

        // String mit $ verknüpfen
        Text = $"Die Zahl ist: {Nummer} und {{das}} wars";
        Console.WriteLine(Text);

        // String direkt ausgeben
        Console.WriteLine($"Die Zahl ist: {Nummer} und das wars");

        // Variable Eingabe als String
        string Eingabe;
        Console.WriteLine("Bitte geben Sie etwas ein:");
        Eingabe = Console.ReadLine();

        //Eingabe wird ausgegeben
        Console.WriteLine($"Sie haben eingegeben: {Eingabe}");

        // Variable ZahlEingabe als int
        int ZahlEingabe;
        Console.WriteLine("Bitte geben Sie eine Zahl ein:");
        ZahlEingabe = int.Parse(Console.ReadLine());

        //ZahlEingabe wird ausgegeben
        Console.WriteLine($"Sie haben die Zahl {ZahlEingabe} eingegeben");


        String beispielString = ZahlEingabe.ToString();



        //neues Zahlenarray mit Länge 5 und wird mit Werten befüllt
        int [] Zahlen = new int[] { 2, 5, 7, 9, 12 };
        //Zahlenarray an der Stelle 2 wird ausgegeben
        Console.WriteLine(Zahlen[2]);
        //Zahlenarray an der Stelle 2 wird auf 10 gesetzt
        Zahlen[2] = 10;
        //Zahlenarray an der Stelle 2 wird ausgegeben
        Console.WriteLine(Zahlen[2]);


        //Die Länge des Arrays wird ausgegeben
        Console.WriteLine("Länge des Arrays: " + Zahlen.Length);
        // Enthält das Array den Wert 7?
        Console.WriteLine("Enthält das Array den Wert 7? " + Zahlen.Contains(10));
        // Maximum von Zahlen
        Console.WriteLine("Maximum: " + Zahlen.Max());
        // Minimum von Zahlen
        Console.WriteLine("Minimum: " + Zahlen.Min());
        // Summe von Zahlen
        Console.WriteLine("Summe: " + Zahlen.Sum());


        // zweidimensionales array mit 3 Zeilen und 4 Spalten
        int[,] Zahlen2D = new int[3, 4];
        // Wert an der Stelle 1, 2 wird auf 5 gesetzt
        Zahlen2D[1, 2] = 5;
        // Wert an der Stelle 0, 1 wird auf 3 gesetzt
        Zahlen2D[0, 1] = 3;

        // Wert an der Stelle 1, 2 wird ausgegeben
        Console.WriteLine(Zahlen2D[1, 2]);
        // Wert an der Stelle 0, 1 wird ausgegeben
        Console.WriteLine(Zahlen2D[0, 1]);


        // - 3 - -
        // - - 5 -
        // - - - -
        // - - - -

        //neues Zahlenarray mit Länge 5 und wird mit Werten befüllt
        int[] Zahlen2 = new int[] { 2, 2, 2, 2, 2};


        if(Zahlen2.Sum() > 10)
        {
            Console.WriteLine("Die Summe ist größer als 10");
        } else if(Zahlen2.Sum() == 10)
        {
            Console.WriteLine("Die Summe ist gleich 10");
        }
        else
        {
            Console.WriteLine("Die Summe ist kleiner  10");
        }


        String wiederholen = "";
        do
        {
            //neues Zahlenarray mit Länge 5 und wird mit Werten befüllt
            int[] Zahlen2 = new int[] { 2, 2, 2, 2, 2 };


            if (Zahlen2.Sum() > 10)
            {
                Console.WriteLine("Die Summe ist größer als 10");
            }
            else if (Zahlen2.Sum() == 10)
            {
                Console.WriteLine("Die Summe ist gleich 10");
            }
            else
            {
                Console.WriteLine("Die Summe ist kleiner  10");
            }

            Console.WriteLine("Wollen sie das program erneut starten? (j/n)");
            wiederholen = Console.ReadLine();

        } while (wiederholen == "j");



        //neues int array mit 5 elementen
        int[] Zahlen = new int[] { 2, 5, 7, 9, 12 };

        //for schleife gibt jede Zahl aus
        for(int i  = 0; i < Zahlen.Length; i++)
        {
            Console.WriteLine(Zahlen[i]+" der Index ist " +i);
        }
        Console.WriteLine("Schleife zu Ende");

        //foreach schleife gibt jede Zahl aus
        foreach(int Zahl in Zahlen)
        {
            Console.WriteLine(Zahl);
        }
        */
    
    // Methode Addieren mit 2 Parametern
    /*static int Addieren(int a, int b)
    {
        return a+b;
    }*/
}









