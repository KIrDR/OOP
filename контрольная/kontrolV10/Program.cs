using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace kontrolV10
{
   class Program
    {
        public static void Main ()
        {

                var my = new MyCollerction<int>();

                var my2 = new MyCollerction<double>();

                my2.Add(123.41);
                my2.Add(123.41);

                my2.Add(124);
                my2.Add(123.41);

            Console.WriteLine(my2.Find(123.41));

            var ch = new MyCollerction<char>();
            ch.listik.Add('S');
            ch.listik.Add('O');
            ch.listik.Add('S');
            ch.listik.Add('I');
            ch.listik.Add('L');
            ch.listik.Add('O');
            ch.listik.Add('X');

            HashSet<char> penis = new HashSet<char>();
            
            for (int i = 0 ; i < ch.listik.Count; i++)
            {
                penis.Add(ch.listik[i]);
            }

            MyCollerction<char> listWithOutPovtor = new MyCollerction<char>();
            
            listWithOutPovtor.listik = penis.ToList<char>();

            listWithOutPovtor.listik.Sort();
            listWithOutPovtor.Print();

            var first3 = listWithOutPovtor.listik.Take(3);

            List<char> listfirst3 = new List<char>();
            foreach (var n in first3)
            {
                listfirst3.Add(n);
            }

            for (int i = 0; i < listfirst3.Count; i++)
                Console.WriteLine("\t"+ listfirst3[i]);


            var sub = new Sub();
            var nooo = new News();

            nooo.post += new Omg(sub.Read);

            nooo.WrightNews(); 
        }
    }
}