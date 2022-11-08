

namespace laba05
{
    internal class InvalidDivisionByZeroException : ArgumentException
    {
        public string Value { get; }
        public InvalidDivisionByZeroException(string message, string name) : base(message)
        {
            Value = name;
            Data.Add("Division by Zero", DateTime.Now);
        }
    }
}
