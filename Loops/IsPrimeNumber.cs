using System;
namespace Loops;

	public class IsPrimeNumber
	{
    public static bool PrimeNumber(int number)
    {
        bool result = true;
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                result = false;
                i = number;
            }
        }
        return result;
    }
}

