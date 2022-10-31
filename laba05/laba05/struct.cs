using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba05
{
    public struct Color
    {
        public byte alpha;
        public byte red;
        public byte green;
        public byte blue;

        public Color(byte alpha, byte red, byte green, byte blue)
        {
            this.alpha = alpha;
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

    }
}
