using System.Linq;

namespace kontrol2
{

    class Program
    {
        static void Main(string[] args)
        {

            var set = new HashSet<int>() { 1, 5, 6, 7, 2 };
            Car ooo = new Car("goovach");
            Car nnn = new Car("Leshiiiq");
            HashSet<Car> set2 = new HashSet<Car> {ooo,nnn};

            int size = set2.Count(n => n.name == "goovach" );

            Console.WriteLine(size);
        }

    }

}