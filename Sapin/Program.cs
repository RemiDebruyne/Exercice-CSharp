Console.WriteLine("De quelle taille doit être le sapin");
Console.WriteLine("De quelle taille doit être le tronc");

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
            Console.WriteLine(string.Concat(Enumerable.Repeat("*", etoile)));
            etoile++;
            etoile++;
        }
        for (int i = 0; i < tronc; i++)
        {
            Console.Write(string.Concat(Enumerable.Repeat(" ", taille - 2)));
            Console.WriteLine("| |");
        }
    }
}




