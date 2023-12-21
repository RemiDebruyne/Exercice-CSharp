// See https://aka.ms/new-console-template for more information
Console.WriteLine("--- Quelle est la nature du triangle ABC ? ---\n \n" +
    "Entrez la longueur du segment AB en cm :");
double AB = double.Parse(Console.ReadLine());

Console.WriteLine("Entrez la longueur du segment BC : ");
double BC = double.Parse(Console.ReadLine());

Console.WriteLine("Entrez la longueur du segment CA : ");
double CA = double.Parse(Console.ReadLine());


if (AB == BC && BC == CA)
    Console.WriteLine("Le triangle est équiatéral");

else if (AB == CA)
    Console.WriteLine("Le triangle est isocèle en A");

else if (AB == BC)
    Console.WriteLine("Le triangle est isocèle en B");

else if (BC == CA)
    Console.WriteLine("Le triangle est isocèle en C");

else
    Console.WriteLine("Le triangle n'est pas isocèle ni équilatéral");