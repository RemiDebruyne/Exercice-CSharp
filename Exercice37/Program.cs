string[] annee = { "janvier", "févirer", "mars", "avril", "mai", "juin", "juillet", "aout", "septembre", "novembre", "décembre" };

int espace = 0;
foreach (string mois in annee)
{
    Console.WriteLine(string.Concat(Enumerable.Repeat("\t", espace)) + mois);
    espace++;
}