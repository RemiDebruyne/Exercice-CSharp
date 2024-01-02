using System.Diagnostics;
using System.Drawing;

Console.WriteLine("De quelle taille doit être le sapin");
Console.WriteLine("De quelle taille doit être le tronc");

Random rnd = new Random();
// liste des couleurs pour les décorations
ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.Magenta, ConsoleColor.Cyan, ConsoleColor.Yellow };

// Liste des décorations possibles
string[] sapin = { "*", "O" };

// Séléctions aléatoires des décorations
int decoration = rnd.Next(sapin.Length);

// Génération du sapin
if (!int.TryParse(Console.ReadLine(), out int taille))
    Console.WriteLine("Valeur inccorecte");
else
{
    if (!int.TryParse(Console.ReadLine(), out int tronc))
    {
        Console.WriteLine("valeur incorrecte");
    }
    else
    {

        int etoile = 1;
        int espace = taille;
        for (int i = 1; i <= taille; i++)
        {
            Console.Write(string.Concat(Enumerable.Repeat(" ", espace - 1)));
            espace--;
            for (i = 1; i <= etoile; i++)
            {
                Console.Write(sapin[decoration]);
            }
            Console.WriteLine();
            etoile += 2;
        }
        for (int i = 0; i < tronc; i++)
        {
            Console.Write(string.Concat(Enumerable.Repeat(" ", taille - 2)));
            Console.WriteLine("| |");
        }
    }
}





