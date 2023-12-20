// See https://aka.ms/new-console-template for more information
Console.WriteLine("---Calcul d'inérêts --- \n" +
    "Entrez le Capital de départ (en Euros) : ");
double capitalDepart = double.Parse(Console.ReadLine());


Console.WriteLine("Entrez le taux d'intérêt (en %) :");
double txInteret = double.Parse(Console.ReadLine()) / 100;

Console.WriteLine("Entre la durée de l'épargne en année :");
double duree = double.Parse(Console.ReadLine());

double montantInteret = capitalDepart * Math.Pow(1 + txInteret / 100, duree) - capitalDepart;
double capitalFinal = capitalDepart + montantInteret;

Console.WriteLine($"Le montant des intérêts sera de {Math.Pow(montantInteret, duree)} Euros après {duree} ans \n" +
    $"Le capital final sera de {capitalFinal} Euros");

