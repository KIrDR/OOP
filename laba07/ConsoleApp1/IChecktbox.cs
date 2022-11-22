using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba03
{
    public class Checktbox : ElemOfManage, IManagement
    {
        // ☐ ☑ ☒
        // ☐ ☑ ☒
        // ☐ ☑ ☒
        public void Show()
        {
            Console.WriteLine("Это CheckBox ") ;
        }
        public void Input()
        {
            Console.WriteLine("Считывается значение CheckBox") ;
            if ( Tap )
            {
                Console.WriteLine("\nCheckBox отмечен ☑ ");
            }
            else
            {
                Console.WriteLine("\nCheckBox НЕ отмечен ☐");
            }

        }

        public override string ToString()
        {
            return $"Это Checktbox";
        }


    }
}
