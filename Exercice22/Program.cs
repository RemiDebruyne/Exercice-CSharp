﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("--- Les tables de multipliplication");
Console.WriteLine();

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Table de {i}");
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"\t - {i} x {j} = {i * j}");
    }
}
