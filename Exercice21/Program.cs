// See https://aka.ms/new-console-template for more information
Console.WriteLine("--- Menus et sous menu --- \n\n" +
    "Table des matières : ");

for (int i = 1; i < 4; i++)
{
    Console.WriteLine($"\tChapitre {i} \n" +
        $"\t\t -Partie {i}.1\n" +
        $"\t\t -Partie {i}.2\n" +
        $"\t\t -Partie {i}.3");
}
