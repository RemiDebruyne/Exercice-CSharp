// See https://aka.ms/new-console-template for more information
Console.WriteLine("Dans quelle catégorie mon enfant est-il... ?");
Console.WriteLine("Entrez l'âge de votre enfant");

if (int.TryParse(Console.ReadLine(), out int age))
    switch (age)
    {
        case >= 3 and <= 6:
            Console.WriteLine("Votre enfant est dans la catégorie \"Baby\"");
            break;
        case >= 7 and <= 8:
            Console.WriteLine("votre enfant est dans la catégorie \"Poussin\"");
            break;
        case >= 9 and <= 10:
            Console.WriteLine("votre enfant est dans la catégorie \"Pupille\"");
            break;
        case >= 11 and <= 12:
            Console.WriteLine("votre enfant est dans la catégorie \"Minime\"");
            break;
        case > 13:
            Console.WriteLine("votre enfant est dans la catégorie \"Cadet\"");
            break;
    }
else
    Console.WriteLine("La valeur n'est pas correcte");
