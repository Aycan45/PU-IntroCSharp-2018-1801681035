using System;

namespace MyUniqueNumber
{
    class MyUniqueNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int myAge = 19;
            Console.WriteLine("19");
            Console.WriteLine("Enter the last 4 digits of your faculty number here:");
            int last4Digits = 1035;
            Console.WriteLine("1035");

            double result = myUniqueNumber(AgeAfter10Years(myAge), last4Digits);

            Console.WriteLine("After 10 years you will be {0} years old. And your unique number is {1}", AgeAfter10Years(myAge), Math.Round(result, 4));
        }

        private static int AgeAfter10Years(int myAge)
        {
            int ageAfter10Years = myAge + 10;

            return ageAfter10Years;
        }

        static double myUniqueNumber(int ageAfter10Years, int last4DigitsOfFacNumber)
        {
            double myUniqueNumber = (ageAfter10Years * last4DigitsOfFacNumber) / Math.PI;

            return myUniqueNumber;
        }

    }
}   


