using System.Collections.Generic;

namespace PrimeTables.Math
{
    public class PrimeNumbersGenerator : IPrimeNumbersGenerator
    {
        public int[] Generate(int primeNumbersCount)
        {
            if (primeNumbersCount <= 0)
            {
                return new int[0];
            }

            var result = new List<int>();
            var numberToCheck = 1;
            while (primeNumbersCount > 0)
            {
                numberToCheck++;
                if (IsPrimeNumber(numberToCheck))
                {
                    result.Add(numberToCheck);
                    primeNumbersCount--;
                }
            }

            return result.ToArray();
        }

        private static bool IsPrimeNumber(int numberToCheck)
        {
            var number = 2;
            while (number < numberToCheck)
            {
                var timesCount = numberToCheck / number;
                if (timesCount * number == numberToCheck) return false;

                number++;
            }
            return true;
        }
    }
}
