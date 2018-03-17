using Domain;
using NUnit.Framework;

namespace Tests
{
    public class WhenAddTwoNumbers
    {
        [Test]
        public void CalculatorReturnsTheirSum()
        {
            var calculator = new Calculator();

            var sum = calculator.Add("1,2");

            Assert.That(sum, Is.EqualTo(1 + 2));
        }
    }
}