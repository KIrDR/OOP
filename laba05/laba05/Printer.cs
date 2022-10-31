using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba05
{
    public sealed class Printer 
    {
        public static void IAmPrinting(IManagement element)
        {
            if (element is AbstaractFigure)
            {
                Console.WriteLine($"Type object({element.GetType()}): " + element);
            }
            else
            {
                var temp = element as ElemOfManage;
                if (temp != null)
                    Console.WriteLine($"Type object({temp.GetType()}): " + temp);
            }
        }
    }
}
