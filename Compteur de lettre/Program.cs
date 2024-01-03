

//Avec foreach

/*int compter_lettre_a(string chaine)
{
    int result = 0;
    foreach (char lettre in chaine)
    {
        if (lettre == 'a')
            result++;
    }

    return result;
}
Console.WriteLine(compter_lettre_a("C'est le b-a ba"));*/


//Avec la méthode

int compterNombreDeA(string chaine)
{
    return chaine.ToLower().Count(c => c == 'a');
}

Console.WriteLine(compterNombreDeA("C'est le b-a ba"));
