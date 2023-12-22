// See https://aka.ms/new-console-template for more information
using System.Threading.Channels;

Console.WriteLine("--- Les tables de multipliplication");
Console.WriteLine();

Console.WriteLine("Combien de table voulez vous");
int tables = int.Parse(Console.ReadLine());



for (int i = 1; i <= tables; i++)
{
    Console.WriteLine(string.Concat(Enumerable.Repeat("+---", 10)) + "+");

    for (int j = 1; j <= 10; j++)
    {

            Console.Write($"|{i * j,3}");

    }
    Console.WriteLine("|");
}
Console.WriteLine(string.Concat(Enumerable.Repeat("+---", 10)) + "+");



/*for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"\t - {i} x {j} = {i * j}");
    }
}*/

