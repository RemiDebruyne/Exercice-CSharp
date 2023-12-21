Console.WriteLine("--- Quelle sera le montant de l'indemnité de licenciement ? ---");
Console.WriteLine();

Console.WriteLine("Merci de saisir le dernier salaire en euros : ");
if (!int.TryParse(Console.ReadLine(), out int salaire ))
    Console.WriteLine("La valeurn n'est pas correcte");

Console.WriteLine("Merci de saisir votre age : ");
if (!int.TryParse(Console.ReadLine(), out int age))
    Console.WriteLine("La valeurn n'est pas correcte");

Console.WriteLine("Merci de saisir le nombre d'années d'ancienneté : ");
if (!int.TryParse(Console.ReadLine(), out int annee))
    Console.WriteLine("La valeurn n'est pas correcte");

int avantDixAns = salaire / 2 * (annee - 1);
int apresDixAns = salaire / 2 * 10 + salaire * (annee - 10);

if (annee < 1)
    Console.WriteLine("Pas de sous mon loulou");

else if (annee <= 10)
{
    if (age > 50)
        Console.WriteLine($"Votre indemnité est deux {avantDixAns + salaire * 5}");
    else if (age >= 46 && age <= 49)
        Console.WriteLine($"Votre indemnité est deux {avantDixAns + salaire * 2}");
    else
        Console.WriteLine($"Votre indemnité est deux {avantDixAns}");

}

else
{
    if (age > 50)
        Console.WriteLine($"Votre indemnité est deux {apresDixAns + salaire * 5}");
    else if (age >= 46 && age <= 49)
        Console.WriteLine($"Votre indemnité est deux {apresDixAns + salaire * 2}");
    else
        Console.WriteLine($"Votre indemnité est deux {apresDixAns}");
}

