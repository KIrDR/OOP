using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba05
{
    public class Button : ElemOfManage, IManagement
    {
        public new void Show()
        {
            Console.WriteLine("Это КНОПКА");
        }

        public new void Input()
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
