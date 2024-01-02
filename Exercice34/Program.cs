Console.WriteLine("Est pair ou Impair ?");
Console.WriteLine("Combiens de nombre contiendra le tableau ? : ");
Random rnd = new Random();
int num = 0;
int[] tableau = new int[num];


if (!int.TryParse(Console.ReadLine(), out  num))
    Console.WriteLine("Valeur inccorecte");
else
{
    for (int i = 0; i < tableau.Length; i++)
    {
        tableau[i] = rnd.Next(1, 51);
    }
}



