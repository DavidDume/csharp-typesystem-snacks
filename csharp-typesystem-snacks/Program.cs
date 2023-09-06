// See https://aka.ms/new-console-template for more information

//SNACK 1  
Console.WriteLine("Inserisci primo numero:");
int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Inserisci secondo numero:");
int numero2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Il numero maggiore è: {(numero1 < numero2 ? numero2 : numero1)}");

//SNACK 2   
Console.WriteLine("Inserisci prima parola:");
string parola1 = Console.ReadLine();

Console.WriteLine("Inserisci prima parola:");
string parola2 = Console.ReadLine();

if(parola1.Length < parola2.Length)
{
    Console.WriteLine($"{parola2} - {parola1}");
} else
{
    Console.WriteLine($"{parola1} - {parola2}");
}

//SNACK 3

int somma = 0;

for(int i = 0; i < 10; i++)
{
    int numeroInserito = int.Parse(Console.ReadLine());
    somma += numeroInserito;
}

Console.WriteLine(somma);

//SNACK 4   
