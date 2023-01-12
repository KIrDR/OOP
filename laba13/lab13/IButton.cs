using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_APP_4
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
