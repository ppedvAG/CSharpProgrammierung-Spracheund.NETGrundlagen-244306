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
