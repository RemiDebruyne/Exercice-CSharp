// See https://aka.ms/new-console-template for more information
Console.WriteLine("--- Les tables de multipliplication");
Console.WriteLine();

Console.WriteLine("Combien de table voulez vous");
int tables = int.Parse(Console.ReadLine());

for (int i = 1; i <= tables; i++)
{
    Console.WriteLine("\n+---+---+---+---+---+---+---+---+---+---+");
    for (int j = 1; j <= 10; j++)
    {
        if (i * j < 10)
            Console.Write($"  {i * j}|");
        else if(i * j > 10);
        Console.Write($" {i * j}|");
    }
}

/*for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"\t - {i} x {j} = {i * j}");
    }
}*/

