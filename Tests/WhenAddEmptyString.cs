using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class WhenAddEmptyString
    {
        [Test]
        public void CalculatorReturnsZero()
        {
            var calculator = new Calculator();

            var sum = calculator.Add("");

            Assert.That(sum, Is.Zero);
        }
    }

    public class Calculator
    {
        public int Add(string value)
        {
            return 0;
        }
    }
}