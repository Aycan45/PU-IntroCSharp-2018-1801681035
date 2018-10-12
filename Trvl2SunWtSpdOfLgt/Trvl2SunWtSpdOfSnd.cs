using System;

namespace Trvl2SunWtSpdOfSnd
{
    class Trvl2SunWtSpdOfSnd
    {
        static void Main(string[] args)
        {
            const long distance2SunFromEarth = 149600000; 
            const short speedOfSoundIn20DegreeWater = 1481; 

            double timeNeeded =(double) distance2SunFromEarth / speedOfSoundIn20DegreeWater;
            Console.WriteLine($"Time needed: {timeNeeded}");
        }
    }
}
