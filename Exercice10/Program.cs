Console.WriteLine("La lettre est-elle une voyelle");

/*string letter = Console.ReadLine().ToLower();

if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "y")
    Console.WriteLine("La lettre est une voyelle");
else
    Console.WriteLine("t'es nul");*/



string letter = Console.ReadLine()!.ToLower();
string voyelle = "aeiouy";

if (voyelle.Contains(letter) && letter.Length == 1)
    Console.WriteLine("La lettre est une voyelle");
else Console.WriteLine("c'est non");
    