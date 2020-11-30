using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
                try
                {
                    Console.Write("Enter Temperature in Centigrates: ");
                    string inp = Console.ReadLine();
                    decimal tempInC = Convert.ToDecimal(inp);
                    switch (tempInC < 0 ? 0 : Math.Ceiling((tempInC + Convert.ToDecimal(Math.Pow(0.1, inp.Length - 1))) / 10))
                    {
                        case 0:
                            Console.WriteLine("Freezing weather");
                            break;
                        case 1:
                            Console.WriteLine("Very Cold weather");
                            break;
                        case 2:
                            Console.WriteLine("Cold weather");
                            break;
                        case 3:
                            Console.WriteLine("Normal in Temp");
                            break;
                        case 4:
                            Console.WriteLine("Its Hot");
                            break;
                        default:
                            Console.WriteLine("Its Very Hot");
                            break;
                    }
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Type Re-enter Temperature Value!");
                }
        }
    }
}