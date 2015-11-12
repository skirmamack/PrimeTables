using NUnit.Framework;
using PrimeTables.Math;
using System.Collections.Generic;

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

        [Test]
        public void should_generate_table_of_correct_size()
        {
            var primeTable = _primeTableGenerator.Generate(_testPrimesCount);

            Assert.That(primeTable.GetUpperBound(0), Is.EqualTo(_testPrimesCount));
            Assert.That(primeTable.GetUpperBound(1), Is.EqualTo(_testPrimesCount));
        }

        [Test]
        public void first_row_columns_values_except_of_top_left_corner_should_be_prime_numbers()
        {
            var primeTable = _primeTableGenerator.Generate(_testPrimesCount);

            var primeNumbers = new PrimeNumbersGenerator().Generate(_testPrimesCount);
            var firstRowColumnValuesList = new List<int>();

            for (var columnIndex = 1; columnIndex <= _testPrimesCount; columnIndex++)
            {
                firstRowColumnValuesList.Add(primeTable[0, columnIndex]);
            }

            Assert.That(firstRowColumnValuesList.ToArray(), Is.EqualTo(primeNumbers));
        }
    }
}
