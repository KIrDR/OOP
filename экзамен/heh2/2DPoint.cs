using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heh2
{
    public class _2DPoint
    {

        public void ChangeT()
        {
            X = -X;
            Y = -Y;
        }
        public _2DPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X;
        public int Y;
    }
}
