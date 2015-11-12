using NUnit.Framework;
using PrimeTables.Math;

namespace PrimeTables.Tests
{
    [TestFixture]
    public class PrimeTableGeneratorTests
    {
        private PrimeTableGenerator _primeTableGenerator;
        private int _testPrimesCount = 15;

        [SetUp]
        public void SetUp()
        {
            _primeTableGenerator = new PrimeTableGenerator();
        }
    }
}
