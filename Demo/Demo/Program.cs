/*// neue Variable Nummer wird der Wert 5 zugewiesen
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
*/


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











