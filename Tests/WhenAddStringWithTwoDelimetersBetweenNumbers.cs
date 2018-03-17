using System;
using Domain;
using NUnit.Framework;

namespace Tests
{
    public class WhenAddStringWithTwoDelimetersBetweenNumbers
    {
        [Test]
        public void ExceptionWasThrown()
        {
            var calculator = new Calculator();

            Assert.Throws<ArgumentException>(() => calculator.Add("1,\n"));
        }
    }
}