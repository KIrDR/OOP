using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba05
{
    internal class InvalidTypeException : ArgumentException
    {

        public int Value { get; }
        public InvalidTypeException(string message, int type) : base(message)
        {
            Value = type;
            Data.Add("Time exception", DateTime.Now);
        }
    }
}
