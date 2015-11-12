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

        [Test]
        public void should_generate_table_of_correct_size()
        {
            var primeTable = _primeTableGenerator.Generate(_testPrimesCount);

            Assert.That(primeTable.GetUpperBound(0), Is.EqualTo(_testPrimesCount));
            Assert.That(primeTable.GetUpperBound(1), Is.EqualTo(_testPrimesCount));
        }
    }
}
