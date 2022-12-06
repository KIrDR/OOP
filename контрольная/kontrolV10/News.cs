using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontrolV10
{
    public delegate void Omg();

    public class Sub
    {
        public void Read()
        {
            Console.WriteLine("ЧИТАЮ НОВОСТЬ");
        }
    }
    public class News
    {
        public event Omg post;

        public void WrightNews()
        {
            if (post != null)
                post();
        }
    }
}
