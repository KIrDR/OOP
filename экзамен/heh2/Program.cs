

using System.Reflection;

namespace heh2
{
    class Program
    {
        public static void Main()
        {

            var p1 = new _2DPoint(1,2);
            var p2 = new _2DPoint(67,22);

            var p3 = new _2DPoint(11, 12);
            var p4 = new _2DPoint(51, 62);
            var p5 = new _2DPoint(51, 42);

            var map1 = new _2Dpath(); 
            var map2 = new _2Dpath();

            map1.Add(p1);
            map1.Add(p2);
            map1.Add(p3);
            map1.Add(p4);
            map1.Add(p5);

            map1.Change += new Ch(p1.ChangeT);
            map1.Change += new Ch(p2.ChangeT);
            map1.Change += new Ch(p3.ChangeT);
            map1.Change += new Ch(p4.ChangeT);

            map1.ChandeHo();

            map1.CountPoint();

            map1.Delete(p4);

            map1.Clear();
            map1.Add(p1);
            map1.Add(p1);

            map2.Add(p2);

            map2.Add(p2);
            Console.WriteLine($"{map1 == map2}");

            map2.Clear();
            try
            {
                map2.Delete(p1);

            }
            catch(DeleteExсeption e)
            {
                Console.WriteLine("Вот так бывает");
                Console.WriteLine(e.Message); 
            }


            var myType = map1.GetType();

            ConstructorInfo[] p = typeof(_2Dpath).GetConstructors();
            foreach(var n in p)
            {
                Console.WriteLine(n.Attributes);
                Console.WriteLine(n.Name);
            }
            var g = typeof(_2Dpath).GetFields();
            foreach (var n in p)
            {
                Console.WriteLine(n.Name);
                Console.WriteLine(n.Name);

            }



        }
    }
}