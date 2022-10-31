using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class3
    {

        public static void Main()
        {
            string[] tokens;
            tokens = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(tokens[0]);

            int Ansver = a - 1;
            int[] OCHERED = new int[a];

            var numbers = new int[a];
            /*
                        var list = numbers.ToList();

                        var resultList = list.GetRange(2, 3);

                        var result = resultList.ToArray();*/

            for (int i = 0; i < a; i++)
            {
                OCHERED[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int j = 2; j < a; j++)
            {

                for (int o = 0; o < a; o++) { 
                var list = OCHERED.ToList();

                var resultList = list.GetRange(j-3, o);

                var result = resultList.ToArray();

                for (int l = 0; l < result.Length; l++)
                {
                    if (OCHERED[j-2] > result[l] && OCHERED[0+2] > result[l])
                    {
                            Ansver++;
                    }
                }
                }

            }
            Console.WriteLine(Ansver);

            
        }
    }
}
