// See https://aka.ms/new-console-template for more information
Console.WriteLine("--- Accroissement de la population --- \n");

double population = 96809;
int annee = 2015;

for (int i = 0; population < 120000; i++)
{
    population *=  1.0089 ;
    annee++;    
    if (population >= 120000)
    {
        Console.WriteLine($"Il faudra {i} ans, nous serons en {annee}");
        Console.WriteLine($"Il y aura {Math.Floor(population)} habitants en {annee}");
    }
}
