using System;

namespace DistanceBtw2PointsInPlane
{
    class DistanceBtw2PointsInPlane
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We need to do calculations:");
            Console.WriteLine("Enter xA:4");
            sbyte xA = 4;
            Console.WriteLine("Enter yA:3");
            sbyte yA = 3;
            Console.WriteLine("Enter xB:1");
            sbyte xB = 1;
            Console.WriteLine("Enter yB:2");
            sbyte yB = 2;

            Console.WriteLine("The points have these coordinates");
            Console.WriteLine($"Point A ({xA};{yA})");
            Console.WriteLine($"Point B ({xB};{yB})");

            double distanceBtw2PointsInPlane = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2));
            Console.WriteLine($"The distance between two points in a plane {distanceBtw2PointsInPlane}");
        }
    }
}
