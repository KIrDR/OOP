using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba05
{
    public abstract class AbstaractFigure
    {
        public float pointX;
        public float pointY;
       
        public Color color;

        public void SetColor(byte alpha, byte red, byte green, byte blue)
        {

            color.alpha = alpha;
            color.red = red;
            color.green = green;
            color.blue = blue;
        }
        public override string ToString()
        {
            return $"pointX{pointX} \t pointY{pointY}";
        }

        public abstract void Show();
        
        
    }
}
