using System;

namespace WeightOnDiffPlanet
{
    class Program
    {
        static void Main(string[] args)
        {
            double gravitationalRatio;
            double weightOnPlanet;

            Console.WriteLine("Enter your weight in kgs as measured on Earth:");
            byte weight = 60;
            Console.WriteLine("60");
            

            Console.WriteLine("How much I weight in Jupiter?");
            gravitationalRatio = 2.34;
            weightOnPlanet = weight * gravitationalRatio;
            Console.WriteLine($"You weight approximately {weightOnPlanet} in Jupiter");
        }
    }
}
