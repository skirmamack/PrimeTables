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

            return new[] {1, 1};
        }
    }
}
