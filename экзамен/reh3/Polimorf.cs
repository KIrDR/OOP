using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reh3
{
    public class Point2
    {
        public int x = 10;
        public int y = 20;
        virtual public int Sum() { return x + y; }
    }
    public class ColorPoint2 : Point2
    {
        public int color = 78;
        override public int Sum() { return x * y * color; }
    }
 
    public  class Polimorf
    {

    }
}
