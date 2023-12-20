// See https://aka.ms/new-console-template for more information
Console.WriteLine("Entrez le prix HT de l'objet (en Euros) : ");
decimal prixHT = decimal.Parse(Console.ReadLine());

Console.WriteLine("Entrez le taux de TVA en % : ");
decimal txTVA = decimal.Parse(Console.ReadLine());

decimal montantTVA = prixHT * txTVA / 100;

Console.WriteLine($"Le montant de la TVA est de : {montantTVA} Euros");
Console.WriteLine($"Le prix TTC de l'objet est de {prixHT + montantTVA}");
