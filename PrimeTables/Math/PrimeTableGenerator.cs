using System.Collections.Generic;

namespace PrimeTables.Math
{
    public class PrimeTableGenerator : IPrimeTableGenerator
    {
        private readonly IPrimeNumbersGenerator _primeNumbersGenerator;

        public PrimeTableGenerator()
            : this(new PrimeNumbersGenerator())
        {
        }

        public PrimeTableGenerator(IPrimeNumbersGenerator primeNumbersGenerator)
        {
            _primeNumbersGenerator = primeNumbersGenerator;
        }

        public int[,] Generate(int primeNumbersCount)
        {
            var result = new int[primeNumbersCount + 1, primeNumbersCount + 1];
            var primeNumbers = _primeNumbersGenerator.Generate(primeNumbersCount);

            FillCells(result, primeNumbers);

            return result;
        }

        private static void FillCells(int[,] result, IReadOnlyList<int> primeNumbers)
        {
            for (var rowIndex = 1; rowIndex <= primeNumbers.Count; rowIndex++)
            {
                var primeNumber = primeNumbers[rowIndex - 1];
                result[0, rowIndex] = primeNumber;
                result[rowIndex, 0] = primeNumber;

                FillRowInnerCells(result, rowIndex, primeNumbers);
            }
        }

        private static void FillRowInnerCells(int[,] result, int rowIndex, IReadOnlyList<int> primeNumbers)
        {
            for (var columnIndex = 1; columnIndex <= primeNumbers.Count; columnIndex++)
            {
                result[columnIndex, rowIndex] = primeNumbers[columnIndex - 1] * primeNumbers[rowIndex - 1];
            }
        }
    }
}
