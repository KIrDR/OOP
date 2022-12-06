using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontrol2
{
    public delegate void SomeDelegate();
    public class User
    {
        public event SomeDelegate click;

        public void Click()
        {
            if (click != null)
            {
                click();
            }
        }
    }
}
