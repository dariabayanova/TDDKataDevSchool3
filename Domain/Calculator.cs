using System.Linq;

namespace Domain
{
    public class Calculator
    {
        private int zero;

        public int Add(string numbers)
        {
            if (IsEmpty(numbers))
            {
                return zero;
            }

            return numbers.Split(',').Sum(int.Parse);
        }

        private bool IsEmpty(string value)
        {
            return string.IsNullOrEmpty(value);
        }
    }
}