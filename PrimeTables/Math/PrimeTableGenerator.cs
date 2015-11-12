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

            for(var primeIndex = 0; primeIndex < primeNumbers.Length; primeIndex++)
            {
                result[0, primeIndex + 1] = primeNumbers[primeIndex];
            }

            return result;
        }
    }
}
