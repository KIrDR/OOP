using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_APP_4
{
    public abstract class ElemOfManage : IManagement
    {

        public void Show()
        {

        }

        public void Input()
        {

        }


        public override string ToString()
        {
            return $"Это элемент управления";
        }

        public bool Tap { get; set;  }

    }
}
