Console.WriteLine("--- Le grand tirrage au sort ---!");


string[] personnes = { "Sébastien", "Allan", "Dominique", "Eric", "Anthony", "Yves", "Aguit", "Adrien", "Jerome", "Walid", "Olivier", "Stéphanie", "Yannic", "Christopher", "Brice" };
Random rnd = new Random();
int pIndex = rnd.Next(personnes.Length);
List<string?> personneDejaTiree = new List<string?>();
bool DejaGagne = personneDejaTiree.Contains(personnes[pIndex]);

do
{
    Console.WriteLine("\n1---Effectuer un tirage au sort" +
    "\n2---Voir la liste des personnes déjà tirées" +
    "\n3---Voir la liste des personnes restantes" +
    "\n0---Quitter" +
    "Fates votre choix : ");

    string choix = Console.ReadLine();


    switch (choix)
    {
        case "1":

            Console.Clear();
            string gagnant = personnes[pIndex];
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"L'heureux gagnant est {gagnant} ");
            Console.ResetColor();
            personneDejaTiree.Add(gagnant);
            break;

/*        case "2":
        case "3":
        case "0":*/


    }
}

while (true);



