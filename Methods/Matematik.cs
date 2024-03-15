using System;
namespace Methods;

	public class Matematik
{
    //Aşağıdaki metotlar, method overloading'e bir örnektir.
    public static int Multiply(int number1, int number2)
    {
        return number1 * number2;
    }

    public static int Multiply(int number1, int number2, int number3)
    {
        return number1 * number2 * number3;
    }

    //Params kullanarak sınırsız parametre yaratmak
    public static int Add(params int[] numbers)
    {
        return numbers.Sum();
    }
}

