using System.Linq;

namespace Domain
{
    public class Calculator
    {
        private int zero;
        private readonly char[] separators = {',', '\n'};

        public int Add(string numbers)
        {
            if (IsEmpty(numbers))
            {
                return zero;
            }

            return numbers.Split(separators).Sum(int.Parse);
        }

        private bool IsEmpty(string value)
        {
            return string.IsNullOrEmpty(value);
        }
    }
}