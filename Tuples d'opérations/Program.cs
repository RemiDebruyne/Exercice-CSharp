using System.Buffers;
double numA, numB;
void userInput(string message)
{
    Console.WriteLine(message);
    if (!double.TryParse(Console.ReadLine(), out numA))
        Console.WriteLine("Valeur incorrecte");
    if (!double.TryParse(Console.ReadLine(), out numB))
        Console.WriteLine("Valeur incorrecte");
}
(double, double, double, double) operation (double numA, double numB)
{
    (double MySum, double MyDif, double MyQuotient, double MyProduct) myTuple;
    myTuple.Item1 = numA + numB;
    myTuple.Item2 = numA - numB;
    myTuple.Item3 = numA / numB;
    myTuple.Item4 = numA * numB;

    return myTuple;

}
userInput("Entrez deux nombres");
Console.WriteLine(operation(numA, numB)); 