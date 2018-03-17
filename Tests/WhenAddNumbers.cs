using Domain;
using NUnit.Framework;

namespace Tests
{
    public class WhenAddNumbers
    {
        [Test]
        public void CalculatorReturnsTheirSum()
        {
            var calculator = new Calculator();

            var sum = calculator.Add("1,2");

            Assert.That(sum, Is.EqualTo(1 + 2));
        }

        [Test]
        public void CalculatorSeparateNumbersByNewLineOrComma()
        {
            var calculator = new Calculator();

            var sum = calculator.Add("1\n2,3");

            Assert.That(sum, Is.EqualTo(1 + 2 + 3));
        }
    }
}