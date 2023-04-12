using NUnit.Framework;

namespace NUnitTest.UnitTests
{
    [TestFixture]
    class CalculatorTests
    {
        private static Calculator CreateCalculator()
        {
            return new Calculator();
        }

        [Test]
        public void Add_IfNotSetNumber_ReturnZero()
        {
            Calculator calculator = CreateCalculator();

            int result = calculator.Sum();

            Assert.AreEqual(0, result);

        }
        [Test]
        public void Sum_WhenCalled_ChangesSum()
        {
            Calculator calculator = CreateCalculator();

            calculator.Add(5);
            int lastNumber = calculator.Sum();

            Assert.AreEqual(5, lastNumber);

        }
    }
}
