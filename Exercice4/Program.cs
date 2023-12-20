// See https://aka.ms/new-console-template for more information
Console.WriteLine("Veuillez saisir votre nom : ");
string name = Console.ReadLine();
Console.WriteLine("Veuillez saisir votre prénom : ");
string surname = Console.ReadLine();
Console.WriteLine("Veuillez saisir votre âge ");
string age = Console.ReadLine();
Convert.ToInt32(age, 10);
Console.WriteLine($"Bonjour {surname} {name}, vous avez {age} ans");



