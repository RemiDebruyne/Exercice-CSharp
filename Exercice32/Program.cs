Console.WriteLine("Insertion des valeurs dans le tableau : ");

string[] tableau = new string[10];

for (int i = 0; i < tableau.Length; i++)
{
    Console.Write("saisir la valeur " + (i + 1) + " : ");
    tableau[i] = Console.ReadLine();
}

int espace = 0;
for (int i = 0; i < tableau.Length; i++)
{
    Console.WriteLine(string.Concat(Enumerable.Repeat("\t", espace)) + tableau[i]);
    espace++;
}