// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Net.Security;

Console.WriteLine("--- Trouvez le nombre mystère ---");

Random aleatoire = new Random();
int nbMystere = aleatoire.Next(1, 51);
int nb = 0;
int coup = 0;

do
{
    Console.WriteLine($"Veuillez saisir un nombre : {nb = int.Parse(Console.ReadLine())}");
    if (nb == nbMystere)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Bravo vous avez trouver le nombre mystère !" +
            $"Vous avez trouvé en {coup}");
        Console.ResetColor();

    }


    else if (nb > nbMystere)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\t Le nombre mystère est plus petit");
        Console.ResetColor();
        coup++;
    }


    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\t Le nombre mystère est plus grand");
        Console.ResetColor();
        coup++;
    }
}
while (nb != nbMystere);
