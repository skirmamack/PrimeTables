using NUnit.Framework;
using PrimeTables.Math;

namespace PrimeTables.Tests
{
    [TestFixture]
    public class PrimeNumbersGeneratorTests
    {
        private PrimeNumbersGenerator _generator;

        [SetUp]
        public void SetUp()
        {
            _generator = new PrimeNumbersGenerator();
        }
    }
}
