using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ExceptionRange : Exception
    {

        public int Value { get; }
        public ExceptionRange()
        {

            Data.Add("Time exception", DateTime.Now);
            Console.WriteLine("Ошибка длинны массива ");

        }
    }
}
