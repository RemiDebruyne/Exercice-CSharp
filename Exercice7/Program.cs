// See https://aka.ms/new-console-template for more information
Console.WriteLine("--- Calcul de la longueur de l'hypothnéuse --- \n" +
    "Entrez la longueur du premier coté (en cm) :");
string premierCoteChain = Console.ReadLine();
double premierCote = double.Parse(premierCoteChain);

Console.WriteLine("Entrez la longueur du premier coté (en cm)");
string deuxiemeCoteChain = Console.ReadLine();
double deuxiemeCote = double.Parse(deuxiemeCoteChain);

Console.WriteLine($"La longueur de l'hypthénuse est : {Math.Pow(premierCote, 2) + Math.Pow(deuxiemeCote, 2)}");