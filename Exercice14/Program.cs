// See https://aka.ms/new-console-template for more information
Console.WriteLine("-- Quelle taille dois-je prendre ? ---");

Console.WriteLine("Entrez votre taille en cm : ");
double taille = double.Parse(Console.ReadLine());

Console.WriteLine("Entrez votre poids en kg : ");
double poids = double.Parse(Console.ReadLine());

if (poids >= 43 && poids <= 47)
{
    if (taille <= 169)
        Console.WriteLine("Prenez la taille 1");
    else
        Console.WriteLine("Vous ne pouvez pas vous habiller");
}

else if (poids >= 48 && poids <= 53)
{
    if (taille <= 166)
        Console.WriteLine("Prenez la taille 1");
    else if (taille >= 183)
        Console.WriteLine("Vous ne pouvez pas vous habiller");
    else
        Console.WriteLine("Prenez la taille 2");
}
else if (poids >= 54 && poids <= 59)
{
    if (taille <= 163)
        Console.WriteLine("Prenez la taille 1");
    else if (taille <= 175)
        Console.WriteLine("Prenez la taille 2");
    else
        Console.WriteLine("Prenez la taille 3");

}

else if (poids >= 60 && poids <= 65)
{
    if (taille <= 160)
        Console.WriteLine("Prenez la taille 1");
    else if (taille <= 172)
        Console.WriteLine("Prenez la taille 2");
    else
        Console.WriteLine("Prenez la taille 3");
}

else if (poids >= 66 && poids <= 71)
{
    if (taille <= 157)
        Console.WriteLine("Vous ne pouvez pas vous habiller");
    else if (taille <= 172)
        Console.WriteLine("Prenez la taille 2");
    else
        Console.WriteLine("Prenez la taille 3");
}

else
{
    if (taille <= 160)
        Console.WriteLine("Vous ne pouvez pas vous habiller");
    else
        Console.WriteLine("Prenez la taille 3");
}








