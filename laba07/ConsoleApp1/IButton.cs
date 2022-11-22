using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba03
{
    public class Button : ElemOfManage, IManagement
    {
        public void Show()
        {
            Console.WriteLine("Это КНОПКА");
        }

        public void Input()
        {

            if (Tap)
            {
                Console.WriteLine("\nКнопка зажата");
            }
            else
            {
                Console.WriteLine("\nкнопка Не нажата");
            }

        }

    }
}
