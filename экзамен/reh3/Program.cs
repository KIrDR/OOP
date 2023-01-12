using System.Diagnostics;
using System.Xml.Linq;

namespace reh3
{

    public delegate void Fg();

    public class Point
    {
        public int x = 10; public int y = 20;
        public String ToString() { return "Point " + x + "  " + y; }
    }

    public class ColorPoint : Point
    {
        public int x = -78;//маскирует или скрывает
        public String ToString()
        {//пред-ние можно заглушить, явно скрывает метод из базового класса
            return "ColorPoint " + x + base.ToString();
        }
        new public int Sum()
        {
            return base.x + base.y + x;
        }
    }


    class F
    {

        static F()
        {
            o = 654;
            Console.WriteLine("ГОловачь чьчьь чьчь ");

        }

        public static int o;
        public static int a { get; set; } = 777; 
        public static void Print()
        {
            Console.WriteLine($"o = {o} \t  a = {a}" );
        }
        public void Print(string ki = "")
        {
            Console.WriteLine($"o = {o} \t  a = {a}");
        }
    }

    abstract public class HHH
    {
        public HHH(string t)
        {
            Console.WriteLine(t);
        }
    }

    class HO : HHH
    {
        public HO(string t) : base(t)
        {
            Console.WriteLine(t);
        }
    }

    interface IStudy<out T> {  }
    interface IStudy1<in T> { }

    class Student <T> : IStudy1<T>,IStudy<T> {  }

    class Person {  }

    class Men : Person
    {

    }

    class Program
    {
        static int MathOp(int x, int y)
        {
            try
            {
                int result = x / y;
                return result;  
            } 
            catch(DivideByZeroException)
            {
                Console.WriteLine("Деление на ноль!");
                return 0;
            }
            
        }
        public static void Main()
        {

            //AppDomain newD = AppDomain.CreateDomain("New"); // домен 
            //newD.Load("имя сборки");
            //AppDomain.Unload(newD);


            Process calc = Process.Start("calc.exe");
            Thread.Sleep(4000);
            calc.Kill();

            Console.WriteLine(MathOp(1, 0)) ;
            Person Pasha  = new Men();
            IStudy<Person> Vika = new Student<Person>();
            IStudy<Person> Pavel = new Student<Men>();
            //IStudy<Men> Nikita = new Student<Person>();


            IStudy1<Person> Vika1 = new Student<Person>();
            //IStudy1<Person> Pavel1 = new Student<Men>();
            IStudy1<Men> Nikita1 = new Student<Person>();


            OOP j = new OOP();
            


            HO ko = new HO("asf");

            Point2 a12 = new Point2();
            Console.WriteLine(a12.Sum()); //30
            ColorPoint2 ca100 = new ColorPoint2();
            a12 = ca100;
            Console.WriteLine(a12.Sum());


            But(3,size : 4);

            Console.WriteLine(Program.MAx(0, 4, 6, 7, 8, 9, 5, 2, 5, 63, 347, 235, 346, 346, 6));
            var oj = new { nem = "Анонимный тип "};
            Console.WriteLine($"{oj.nem}");
            Console.WriteLine("dfvidnfvi");
            Console.WriteLine("dfvidnfvi");

            Console.WriteLine("dfvidnfvi");

            Console.WriteLine("dfvidnfvi");

            F.a = 12;
            F.o = 45734;
            F.Print();

            F lol = new F();
                
            lol.Print();
            


            (int, string, char) CreateCortage(string name)
            {
                int len = name.Length;
                string s = "My first name is" + name;
                char ch = (char)(name[0]);
                return (len, s, ch);
            }

            string name = "fvslfvs"; 

            ValueTuple<int, string, Array> g = (first: 1, second: "sdkvs", big: new[] { 3, 4, 7 });
            var h = (first: 1, second: "sdkvs", big: new[] { 3, 4, 7 });
            var iGetIt = CreateCortage(name);
            Console.WriteLine(iGetIt.Item1);
            Console.WriteLine(iGetIt.Item2);
            Console.WriteLine(iGetIt.Item3);


            Console.WriteLine($"");
            foreach(var t in h.big)
            {
                Console.WriteLine(t);
            }


        }


        public static int MAx(int _value, params int[] _arr)
        {
            if (_arr.Length > 0)
                for (int j = 1; j < _arr.Length; j++)
                    if (_arr[j] > _value)
                        _value = _arr[j];
            return _value;
        }

        static void But(int color, int size = 2, int type = 76)
        {
            Console.WriteLine($"{color}{size}{type}");
        }

    }
}