using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace _1_2
{
    public  class Box
    {

        public List<Letter> list = new List<Letter>(); 

        public void Print()
        {
            foreach(var t in list)
            {
                Console.WriteLine(t.Subject);
                Console.WriteLine(t.Text);
                Console.WriteLine(t.addressTo.ФИО + t.addressTo.email);
                Console.WriteLine(t.addressFrom.ФИО + t.addressFrom.email);
                Console.WriteLine(t.Signature);
            }
        }
        public void Add(Letter g)
        {
            list.Add(g);
        }

    }
}
