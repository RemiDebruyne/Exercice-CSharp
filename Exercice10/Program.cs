// See https://aka.ms/new-console-template for more information
Console.WriteLine("La lettre est-elle une voyelle");

/*string letter = Console.ReadLine();

if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "y")
    Console.WriteLine("La lettre est une voyelle");
else
    Console.WriteLine("t'es nul");*/

string? letter = Console.ReadLine();
string voyelle = "aeiou";

if (voyelle.Contains(letter) && letter.Length == 1)
    Console.WriteLine("La lettre est une voyelle");
else Console.WriteLine("c'est non");
    