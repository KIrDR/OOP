/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Class1
    {

        public static void Main()A
        {
          
            int[] Ielements = new int[] { 7, 3, 9, 1 };
            int[] Ielements2 = new int[Ielements.Length];
            int chetchik = 0 ; 

            for (int i = 0; i < Ielements.Length; i++)
            {
                for (int j = i; j < Ielements.Length; j++)
                {
                    if (Ielements[i] > Ielements[j])
                    {
                        chetchik++; 
                    }
                    Ielements2[i] = chetchik; 
                }

                chetchik = 0 ;
            }

            Console.WriteLine("[{0}, {1}, {2}, {3}]", Ielements2[0], Ielements2[1], Ielements2[2], Ielements2[3]);

        }
    }
}
*/