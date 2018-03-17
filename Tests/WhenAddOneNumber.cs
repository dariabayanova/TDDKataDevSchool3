using Domain;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class WhenAddOneNumber
    {
        [Test]
        public void CalculatorReturnsThisNumber()
        {
            var calculator = new Calculator();

            var sum = calculator.Add("1");

            Assert.That(sum, Is.EqualTo(1));
        }
    }
}