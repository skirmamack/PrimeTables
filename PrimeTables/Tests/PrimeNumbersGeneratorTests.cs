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

        [TestCase(-2)]
        [TestCase(0)]
        public void should_generate_empty_array_for_non_positive_primes_count(int primesCount)
        {
            var result = _generator.Generate(primesCount);

            Assert.That(result.Length, Is.EqualTo(0));
        }
    }
}
