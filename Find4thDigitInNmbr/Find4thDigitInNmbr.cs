using System;

namespace Find4thDigitInNmbr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 7-digit number: ");
            int number = 3490135;

            if (number < 1000000 || number > 9999999)
            {
                Console.WriteLine("The number you entered is not a 7-digit number");
            }
            else
            {
                int fourthDigit = number % 1000000 % 100000 % 10000 / 1000;

                Console.WriteLine($"The fourth digit of {number} is {fourthDigit}");
            }
        }
    }
}
