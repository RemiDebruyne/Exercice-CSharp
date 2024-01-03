string nom_complet(string prenom, string nom)
{
    return $"{prenom} {nom}";
}

string nomPrenom = nom_complet("John", "Doe");
Console.WriteLine(nomPrenom);