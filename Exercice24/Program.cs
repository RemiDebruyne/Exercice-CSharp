// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;
/*if (!int.TryParse(Console.ReadLine(), out int num))
    Console.WriteLine("Valeur inccorecte");
else
    for (int i = 1; i < num / 2 + 1; i++)
    {
        int sum = 0;
        for (int j = i; j < num; j++)
        {
            sum += j;
            if (sum == num)
            {
                string affichage = $"{num} = {i}";
                Console.Write(affichage);
                for (int k = i + 1; k <= j; k++)
                {
                    Console.Write($" + {k}");
                }
                Console.WriteLine();
            }
        }
    }*/

if (!int.TryParse(Console.ReadLine(), out int num))
    Console.WriteLine("Valeur inccorecte");
else
    for (int i = 1; i < num / 2 + 1; i++)
    {
        int sum = 0;
        string chain = "";
        for (int j = i; j < num; j++)
        {
            sum += j;
            chain += j + "+";
           // Console.Write(affichage);

            if (sum == num)
            {
                Console.Write(num + " = " + chain.TrimEnd('+'));
                Console.WriteLine();
            }
        }
    }