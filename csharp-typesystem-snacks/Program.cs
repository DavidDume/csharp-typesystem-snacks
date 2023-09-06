//// See https://aka.ms/new-console-template for more information

////SNACK 1  
//Console.WriteLine("Inserisci primo numero:");
//int numero1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Inserisci secondo numero:");
//int numero2 = int.Parse(Console.ReadLine());

//Console.WriteLine($"Il numero maggiore è: {(numero1 < numero2 ? numero2 : numero1)}");

////SNACK 2   
//Console.WriteLine("Inserisci prima parola:");
//string parola1 = Console.ReadLine();

//Console.WriteLine("Inserisci prima parola:");
//string parola2 = Console.ReadLine();

//if (parola1.Length < parola2.Length)
//{
//    Console.WriteLine($"{parola2} - {parola1}");
//}
//else
//{
//    Console.WriteLine($"{parola1} - {parola2}");
//}

////SNACK 3

//int somma = 0;

//for (int i = 0; i < 10; i++)
//{
//    int numeroInserito = int.Parse(Console.ReadLine());
//    somma += numeroInserito;
//}

//Console.WriteLine(somma);

////SNACK 4

//int somma2 = 0;
//for (int i = 2; i <= 10; i++)
//{
//    somma2 += i;
//}

//int media = somma2 / 8;
//Console.WriteLine($"La somma è {somma2} e la media è {media}");

////SNACK 5

//Console.WriteLine("Inserisci numero:");
//int numeroUtente = int.Parse(Console.ReadLine());

//if (numeroUtente % 2 == 0)
//{
//    Console.WriteLine(numeroUtente);
//}
//else
//{
//    Console.WriteLine(numeroUtente + 1);
//}

//// SNACK 6
//string[] invitati = { "giuseppe", "carlo", "paolo" };
//Console.WriteLine("Qaul'è il tuo nome?");
//string nome = Console.ReadLine();
//Console.WriteLine($"{(invitati.Contains(nome) ? "Puoi partecipare" : "Non sei sulla lista")}");

////SNACK 7


//int[] numeriUtente = new int[6];
//for (int i = 0; i <= 5; i++)
//{
//    int numeroUtente = int.Parse(Console.ReadLine());
//    if(i % 2 == 0)
//    {
//        numeriUtente[i] = numeroUtente;

//    }
//}

//SNACK 8

//int[] arr = { 1,2,5,7,5,2,88,23 };
//int somma = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if(i % 2 == 0)
//    {
//        somma += arr[i];
//    }
//}

//Console.WriteLine(somma);

//SNACK 9

int somma = 0;

int[] arr = new int[50];

while (somma < 50)
{

    Console.WriteLine("aggiungi numero");
    int n = int.Parse(Console.ReadLine());
    arr[somma] = n;
    somma += n;
}