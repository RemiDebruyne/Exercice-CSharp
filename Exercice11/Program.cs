// See https://aka.ms/new-console-template for more information
using System.Threading.Channels;

Console.WriteLine("--- Le nombre est-il divisible par... ? --- \n" +
    "Entrez un chiffre/nombre entier :");
int nombreEntier = int.Parse(Console.ReadLine());

Console.WriteLine("Entrez le diviseur entier :");
int diviseur = int.Parse(Console.ReadLine());

if (nombreEntier >= 10)
{
    if (nombreEntier % diviseur == 0)
        Console.WriteLine("Ce nombre est divisible par " + diviseur);
    else
        Console.WriteLine("Ce nombre n'est pas divisible par " + diviseur);
}

else
{
    if (nombreEntier % diviseur == 0)
        Console.WriteLine("Ce chiffre est divisible par " + diviseur);
    else
        Console.WriteLine("Ce chiffre n'est divisible par " + diviseur);

}


