using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num;
            while (true)
                try
                {
                    Console.Write("Enter Number: ");
                    num = Convert.ToDecimal(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR Re-enter Number!");
                }
            while (true)
            {
                Console.WriteLine("Press 1 for Banker's Rounding");
                Console.WriteLine("Press 2 for Old Rounding");
                Console.WriteLine("Enter Option: ");
                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        Console.WriteLine($"\nBy Banker's Rounding: {Convert.ToInt32(num)}");
                        break;
                    case '2':
                        Console.WriteLine($"\nBy Old Rounding: {Math.Round(num, 0, MidpointRounding.AwayFromZero)}");
                        break;
                    default:
                        Console.WriteLine("\nERROR Re-enter Operation!");
                        continue;
                }
                break;
            }
        }
    }
}