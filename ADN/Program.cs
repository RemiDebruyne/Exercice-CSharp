bool verification_adn(string chaine)
{
    Console.WriteLine("Entrez la chaine ADN");
    chaine = Console.ReadLine();
    if (!chaine.Contains('a') && !chaine.Contains('t') && !chaine.Contains('c') && !chaine.Contains('g'))
    {
        return false;
    }
    else
        return true;
}


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


Console.WriteLine(verification_adn(Console.ReadLine()));