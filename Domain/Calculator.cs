namespace Domain
{
    public class Calculator
    {
        private int zero;

        public int Add(string value)
        {
            if (IsEmpty(value))
            {
                return zero;
            }

            return int.Parse(value);
        }

        private bool IsEmpty(string value)
        {
            return string.IsNullOrEmpty(value);
        }
    }
}