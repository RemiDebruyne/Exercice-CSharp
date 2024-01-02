// See https://aka.ms/new-console-template for more information
Console.WriteLine("--- Tableau des notes ---");
Console.WriteLine("Combien de note comportera le tableau ? : ");

int.TryParse(Console.ReadLine(), out int nombreDeNote);
int[] notes = new int[nombreDeNote];

for (int i = 0; i < notes.Length; i++)
{
    Console.WriteLine($"\t- Note {i} :  ");
    notes[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("--- Liste des notes ---");
for (int i = 0;i < notes.Length; i++)
{
    Console.WriteLine($"La note {i} est : {notes[i]}/20");
}
