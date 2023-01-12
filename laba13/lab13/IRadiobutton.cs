using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_APP_4
{
    public class Radiobutton : ElemOfManage, IManagement
    {
        public void Show()
        {
            Console.WriteLine("Это Radiobutton \n");
        }
        public void Input()
        {
            Console.WriteLine("Считывается значение Radiobutton");
            if (Tap)
            {
                Console.WriteLine("\nRadiobutton отмечен  ");
            }
            else
            {
                Console.WriteLine("\nRadiobutton НЕ отмечен ☐");
            }

        }

        public override string ToString()
        {
            return $"Это Кнопка";
        }


    }
}
