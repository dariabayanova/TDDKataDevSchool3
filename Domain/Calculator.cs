using System;
using System.Linq;

namespace Domain
{
    public class Calculator
    {
        private int zero = 0;
        private readonly char[] separators = {',', '\n'};

        public int Add(string numbers)
        {
            if (IsEmpty(numbers))
            {
                return zero;
            }

            return numbers.Split(separators).Sum(ParseNumber);
        }

        private int ParseNumber(string number)
        {
            if (!int.TryParse(number, out var result))
            {
                throw new ArgumentException($"Couldn't parse number {number}.");
            }

            return result;
        }

        private bool IsEmpty(string value)
        {
            return string.IsNullOrEmpty(value);
        }
    }
}