using System;

namespace Assignment1
{
    class Program
    {
        static void Swap(ref decimal a, ref decimal b)
        {
            decimal k = a;
            a = b;
            b = k;
        }
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
            Swap(ref num1, ref num2);
            Console.WriteLine($"After Swap First Number: {num1}");
            Console.WriteLine($"After Swap Second Number: {num2}");
        }
    }
}