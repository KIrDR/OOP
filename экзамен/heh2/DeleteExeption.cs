using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heh2
{
    public class DeleteExсeption : Exception
    {
        public DeleteExсeption()
        {
            Console.WriteLine("Удаляешь из пустого !!! ");
        }
    }
}
