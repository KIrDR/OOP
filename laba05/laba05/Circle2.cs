using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba05
{
    public partial class Circle : AbstaractFigure, IManagement
    {
        public float radius;
        public Color color = new Color();
        public Button? button;
        public Radiobutton? radoibutton;
    }
}