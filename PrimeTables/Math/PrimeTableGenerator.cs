namespace PrimeTables.Math
{
    public class PrimeTableGenerator : IPrimeTableGenerator
    {
        public int[,] Generate(int primeNumbersCount)
        {
            var result = new int[primeNumbersCount + 1, primeNumbersCount + 1];
            return result;
        }
    }
}
