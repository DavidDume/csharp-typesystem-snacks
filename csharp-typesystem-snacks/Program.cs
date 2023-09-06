// See https://aka.ms/new-console-template for more information

//SNACK 1  
Console.WriteLine("Inserisci primo numero:");
int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Inserisci secondo numero:");
int numero2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Il numero maggiore è: {(numero1 < numero2 ? numero2 : numero1)}");