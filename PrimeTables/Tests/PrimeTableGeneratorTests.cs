using System;
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
            var primeNumbers = new PrimeNumbersGenerator().Generate(_testPrimesCount);

            var primeTable = _primeTableGenerator.Generate(_testPrimesCount);
            var firstRowColumnValuesList = GetFirstRowColumnValues(primeTable);

            Assert.That(firstRowColumnValuesList, Is.EqualTo(primeNumbers));
        }

        [Test]
        public void first_column_values_except_of_top_left_corner_should_be_prime_numbers()
        {
            var primeNumbers = new PrimeNumbersGenerator().Generate(_testPrimesCount);

            var primeTable = _primeTableGenerator.Generate(_testPrimesCount);
            var firstColumnValuesList = GetFirstColumnValues(primeTable);

            Assert.That(firstColumnValuesList, Is.EqualTo(primeNumbers));
        }

        [Test]
        public void inner_cell_values_should_be_products_of_their_first_columns_and_first_rows()
        {
            var primeTable = _primeTableGenerator.Generate(_testPrimesCount);
            var primeNumbers = new PrimeNumbersGenerator().Generate(_testPrimesCount);

            for (var rowIndex = 1; rowIndex <= _testPrimesCount; rowIndex++)
            {
                for (var columnIndex = 1; columnIndex <= _testPrimesCount; columnIndex++)
                {
                    var valueToCheck = primeNumbers[rowIndex - 1] * primeNumbers[columnIndex - 1];
                    Assert.That(primeTable[rowIndex, columnIndex], Is.EqualTo(valueToCheck));
                }
            }
        }

        private int[] GetFirstRowColumnValues(int[,] primeTable)
        {
            var firstRowColumnValuesList = new List<int>();

            for (var columnIndex = 1; columnIndex <= _testPrimesCount; columnIndex++)
            {
                firstRowColumnValuesList.Add(primeTable[0, columnIndex]);
            }
            return firstRowColumnValuesList.ToArray();
        }

        private int[] GetFirstColumnValues(int[,] primeTable)
        {
            var firstColumnValuesList = new List<int>();

            for (var rowIndex = 1; rowIndex <= _testPrimesCount; rowIndex++)
            {
                firstColumnValuesList.Add(primeTable[rowIndex, 0]);
            }
            return firstColumnValuesList.ToArray();
        }
    }
}
