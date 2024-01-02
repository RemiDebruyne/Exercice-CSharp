// See https://aka.ms/new-console-template for more information
using System.Net.NetworkInformation;

Console.WriteLine("--- Gestion des notes ---");

int nb = 0;
int note = 0;

do
{
    Console.WriteLine($"Veuillez saisir les notes : " +
        $"(999 pour calculer)");
    Console.WriteLine($"\t - Merci de saisir la note {nb++} : {note = int.Parse(Console.ReadLine())} ");
    
    if (note > 20)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Erreur de saisie, la note est supérieur à 20 !");
        Console.ResetColor();

    }
}

while ( note != 999 );
