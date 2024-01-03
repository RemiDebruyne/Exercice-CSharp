// See https://aka.ms/new-console-template for more information
Console.WriteLine("--- Où est passé mon numéro ---");

Console.WriteLine("Affectation des valeurs...");

Random rdn = new Random();
int[] arr = new int[10];
string espace = "";


for (int i = 0; i < arr.Length; i++)
    arr[i] = rdn.Next(1, 51);

Console.WriteLine("Affichage avant le triage");
foreach (int i in arr)
{
    Console.WriteLine(espace + i);
    espace += " ";
}

int firstNum = arr[0];


Console.WriteLine("\nAffichae après le triage");
Array.Sort(arr);
espace = "";

foreach(int i in arr)
{
    Console.WriteLine(espace + i);
    espace += " ";
}

// +1 car la 1ère valeur est à l'indexe zéro et pas un
Console.WriteLine($"\nLe nombre {firstNum} est à la {Array.IndexOf(arr, firstNum) + 1} position");