using ConsoleApp1;
using System.Linq;

namespace kol
{

     class Program
    {

        public static void Main()
        {

            var golova = new SuperStack<int>();

            golova.Add(1);
            golova.Add(4);
            golova.Add(2);
            golova.Add(17);
            golova.Add(1135);
            golova.Add(41);
            golova.Add(51);

            var nogi = new SuperStack<int>();

            nogi.Add(1);



            var riki = new SuperStack<int>();

            riki.Add(1);
            riki.Add(4);
            riki.Add(2);
            riki.Add(17);
            riki.Add(1135);
            riki.Add(41);
            riki.Add(51);

            Console.WriteLine(golova == nogi);

            Console.WriteLine(golova == riki);


            var telefon = new Telephone();

            var pasha = new User();

            telefon.supeRring += new Ring(pasha.Talk);

            telefon.Call();

            string[] str1 = { "sdnfijsndf", "osjdnvbsdjvsd", " skdvbsdvbsv", "13iy3g4599erhf87d " }; 

            var find = str1.Count(n => n == "osjdnvbsdjvsd");

            Console.WriteLine(find);


            SuperStack<int> first = new SuperStack<int>();
            SuperStack<int> second = new SuperStack<int>();

            try
            {
                Console.WriteLine(first == second);
            }
            catch(InsufficientExecutionStackException e)
            {
                Console.WriteLine(e);
            }

        }
    }



}