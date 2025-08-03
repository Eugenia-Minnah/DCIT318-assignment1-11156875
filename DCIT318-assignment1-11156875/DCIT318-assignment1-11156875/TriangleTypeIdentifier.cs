using System;

namespace DCIT318_assignment1_11156875
{
    public class TriangleTypeIdentifier
    {
        public static void Run()
        {
            Console.Write("Enter side 1: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter side 2: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter side 3: ");
            int c = int.Parse(Console.ReadLine());

            if (a == b && b == c)
                Console.WriteLine("Triangle Type: Equilateral");
            else if (a == b || b == c || a == c)
                Console.WriteLine("Triangle Type: Isosceles");
            else
                Console.WriteLine("Triangle Type: Scalene");
        }
    }
}
