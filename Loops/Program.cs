// See https://aka.ms/new-console-template for more information
using Loops;

//For döngüsü
for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("For Loop bitti.");

//While döngüsü
int number = 100;
while (number>=0)
{
    Console.WriteLine(number);
    number--;
}

Console.WriteLine("While Loop bitti.");

//ForEach döngüsü
string[] students = new string[] { "Engin", "Derin", "Arda" };
foreach (var student in students)
{
    Console.WriteLine(student);
}

Console.WriteLine("Foreach loop bitti");

//PrimeNumber demo method
int primeNumber = Convert.ToInt32(Console.ReadLine());

bool result = IsPrimeNumber.PrimeNumber(primeNumber);


Console.WriteLine(result);
