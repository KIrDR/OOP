using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontrol2
{
    public class Button
    {
        public string text;

        public Button(string text)
        {
            this.text = text;
        }

        public void Click()
        {
            Console.WriteLine(text);
        }
    }
}
