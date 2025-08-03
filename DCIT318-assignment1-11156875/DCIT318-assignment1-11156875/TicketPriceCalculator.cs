using System;

namespace DCIT318_assignment1_11156875
{
    public class TicketPriceCalculator
    {
        public static void Run()
        {
            Console.Write("Enter your age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                int price = (age <= 12 || age >= 65) ? 7 : 10;
                Console.WriteLine($"Ticket Price: GHC{price}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric age.");
            }
        }
    }
}