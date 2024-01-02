// See https://aka.ms/new-console-template for more information
using System.Net.NetworkInformation;

Console.WriteLine("--- Gestion des notes ---");

float max = 20, min = 0, moyenne;
int nbNotes = 1;
int userInput = 0;

Console.WriteLine($"Veuillez saisir les notes : " +
   $"\n(999 pour calculer)");

while ( userInput != 999)
{
    Console.WriteLine($"\t - Merci de saisir la note {nb++} (sur /20) : {userInput = int.Parse(Console.ReadLine())} ");

    if (userInput > 20 && userInput != 999)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Erreur de saisie, la note est supérieur à 20 !");
        Console.ResetColor();

    }
}
