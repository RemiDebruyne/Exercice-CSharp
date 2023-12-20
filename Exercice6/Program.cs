// See https://aka.ms/new-console-template for more information
Console.Write("--- Calcul du périmètre et de l'aire d'un carré --- \n" +
    "Entrez la longueur d'un  coté du carré (en cm) :");
string squareSide = Console.ReadLine();
Console.WriteLine($"Le périmètre du carré est : {float.Parse(squareSide) * 4}");
Console.WriteLine($"L'aire du carré est : {float.Parse(squareSide) * float.Parse(squareSide)}");



