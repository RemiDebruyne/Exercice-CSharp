// See https://aka.ms/new-console-template for more information
Console.WriteLine("Veuillez saiair un nombre : ");
string numA = Console.ReadLine();

Console.WriteLine("Veuillez saiair un nombre : ");
String numB = Console.ReadLine();

int result = int.Parse(numA) + Convert.ToInt32(numB); //both solution to convert readline() from string to int
Console.WriteLine($"La somme de ces deux nombres est : {result}");
