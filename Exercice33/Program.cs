int[] tableau = new int[26];
int ascii = 65;

for (int i = 0; i < tableau.Length; i++)
{
    tableau[i] = ascii;
    ascii++;
}

int espace = 0;
for (int i = 0; i < tableau.Length; i++)
{
    Console.WriteLine(string.Concat(Enumerable.Repeat(" ", espace)) + (char)tableau[i]);
    espace++;
}