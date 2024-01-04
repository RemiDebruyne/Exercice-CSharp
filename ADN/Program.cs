using System.Threading.Channels;

bool verification_adn(string chaine)
{

    if (!chaine.Contains('a') && !chaine.Contains('t') && !chaine.Contains('c') && !chaine.Contains('g'))
    {
        return false;
    }
    else
        return true;
}
Console.WriteLine("Entrez la chaine ADN");
string chaine = Console.ReadLine();
Console.WriteLine(verification_adn(chaine));


string saisie_adn(string saisie)
{
    saisie = Console.ReadLine();
    if (verification_adn(saisie))
        return saisie;
    else
        return "Saisie incorrecte";
}



//string[] chaine = { "a", "t", "c", "g" };

void proportion(string chaine, string sequence)
{

    chaine = Console.ReadLine();
    sequence = Console.ReadLine();
}


