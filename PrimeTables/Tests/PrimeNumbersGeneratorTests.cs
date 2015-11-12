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

        [TestCase(1, new[] { 2 })]
        [TestCase(2, new[] { 2, 3 })]
        [TestCase(3, new[] { 2, 3, 5 })]
        [TestCase(25, new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 })]
        public void should_generate_correct_prime_numbers(int primeNumbersCount, int[] expectedResult)
        {
            var result = _generator.Generate(primeNumbersCount);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
