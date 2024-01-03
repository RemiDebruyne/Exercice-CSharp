
float max = 0, min = 20, sommes = 0, moyenne;
int nombreDeNote;
bool saisieValide;

Console.WriteLine("--- Tableau des notes ---");
//Déclaration du nombre de notes dans le tableau
Console.WriteLine("Combien de note comportera le tableau ? : ");
do
{
    saisieValide = int.TryParse(Console.ReadLine(), out nombreDeNote);

    if (!saisieValide)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Saisie invalide, veuillez entrer un chiffre ou un nombre valide");
        Console.ResetColor();
    }
} while (!saisieValide);

float[] notes = new float[nombreDeNote];

// Déclaration des notes
for (int i = 0; i < notes.Length; i++)
{
    // Controle de saisie des notes
    do
    {
        Console.Write($"\t- Note {i + 1} : ");
        saisieValide = float.TryParse(Console.ReadLine(), out notes[i]) && notes[i] >= 0 && notes[i] <= 20;

        if (!saisieValide)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Saisie invalide, veuillez entrer un chiffre ou un nombre valide");
            Console.ResetColor();
        }
    } while (!saisieValide);

    // calcule des notes max min et de la somme pour la moyenne 
    if (notes[i] > max)
            max = notes[i];
        if (notes[i] < min)
            min = notes[i];
        sommes += notes[i];
}

if (saisieValide)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("\n--- Liste des notes ---");
    Console.ResetColor();
    for (int i = 0; i < notes.Length; i++)
    {
        Console.WriteLine($"La note {i + 1} est de {notes[i]}/20");
    }

        moyenne = sommes / nombreDeNote;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"--- La note max est {max}/20");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"--- La note min est {min}/20");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"--- La note moyenne est de {moyenne}/20");
    Console.ResetColor();

/*    Console.Write("Appuyez sur <Entrer> pour fermer le programme... ");
    while (Console.ReadKey().Key != ConsoleKey.Enter) { }*/



}


