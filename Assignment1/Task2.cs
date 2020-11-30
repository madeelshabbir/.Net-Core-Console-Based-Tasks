using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1, num2;
            while (true)
                try
                {
                    Console.Write("Enter First Number: ");
                    num1 = Convert.ToDecimal(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR Re-enter First Number!");
                }
            while (true)
                try
                {
                    Console.Write("Enter Second Number: ");
                    num2 = Convert.ToDecimal(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR Re-enter Second Number!");
                }
            while (true)
            {
                Console.WriteLine("Press + for Addition");
                Console.WriteLine("Press - for Subtraction");
                Console.WriteLine("Press * for Multiplication");
                Console.WriteLine("Press / for Division");
                Console.WriteLine("Press % for Modulus");
                Console.Write("Enter Operation: ");
                try
                {
                    switch (Console.ReadKey().KeyChar)
                    {
                        case '+':
                            Console.WriteLine($"\nAddition: {num1 + num2}");
                            break;
                        case '-':
                            Console.WriteLine($"\nSubtraction: {num1 - num2}");
                            break;
                        case '*':
                            Console.WriteLine($"\nMultiplication: {num1 * num2}");
                            break;
                        case '/':
                            Console.WriteLine($"\nDivision: {(num1 / num2 != 0 ? num1 / num2 : throw new Exception())}");
                            break;
                        case '%':
                            Console.WriteLine($"\nModulus: {num1 % num2}");
                            break;
                        default:
                            Console.WriteLine("\nERROR Re-enter Operation!");
                            continue;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("/nDivision: Undefined!");
                }
                break;
            }
        }
    }
}