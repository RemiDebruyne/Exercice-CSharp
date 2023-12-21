Console.WriteLine("--- Quelle boisson souhaitez-vous ? ---");

Console.WriteLine("Liste des boissons disponibles :" +
    "1) Eau plate" +
    "2) Eau gazeuse" +
    "3) coca-cola" +
    "4) fanta" +
    "5) sprite" +
    "6) orangina" +
    "7) 7up");

Console.WriteLine("Faites votre choix (1 à 7) : ");
switch (Console.ReadLine())
{
    case "1":
        Console.WriteLine("votre eau plate est servi");
        break;

    case "2": Console.WriteLine("votre eau gazeuse est servi");
        break;

    case "3":
        Console.WriteLine("votre coca-cola est servi");
        break;

    case "4":
        Console.WriteLine("votre fanta est servi");
        break;

    case "5":
        Console.WriteLine("votre sprite est servi");
        break;

    case "6":
        Console.WriteLine("votre orangina est servi");
        break;

    case "7":
        Console.WriteLine("votre eau 7up est servi");
        break;

    default:
        Console.WriteLine("nique ta mère");
        break;
}




