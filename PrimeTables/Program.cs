using System;
using PrimeTables.Math;
using PrimeTables.UI;

namespace PrimeTables
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfPrimes = GetNumberOfPrimesInput();

            if (numberOfPrimes > 0)
            {
                DisplayPrimesTable(numberOfPrimes);
            }

            Console.WriteLine("Press any key.");
            Console.ReadKey();
        }

        private static void DisplayPrimesTable(int numberOfPrimes)
        {
            var primeTableGenerator = new PrimeTableGenerator();
            var primeTable = primeTableGenerator.Generate(numberOfPrimes);

            var displayer = new ConsolePrimeTableDisplayer();
            displayer.Display(primeTable);
        }

        private static int GetNumberOfPrimesInput()
        {
            var numberOfPrimes = -1;
            while (numberOfPrimes <= 0)
            {
                Console.WriteLine("Please input positive number of primes (ENTER exit):");
                var input = Console.ReadLine();
                if (input == string.Empty)
                {
                    numberOfPrimes = 0;
                    break;
                }

                if (!int.TryParse(input, out numberOfPrimes))
                {
                    numberOfPrimes = -1;
                }
            }
            return numberOfPrimes;
        }
    }
}
