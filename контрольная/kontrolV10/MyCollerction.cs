using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontrolV10
{
    public class MyCollerction<T>
    {
        public List<T> listik = new List<T>(); 

        public bool Add(T element)
        {
            if(element is int n)
            {

                listik.Add(element);
                return true;
            }
            else if(element is double m)
            {
                listik.Add(element);
                return true;
            }
            
            else
            {
                throw new Exception("невозможно привести к типу инт");
            }

            

            /*if (element != null)
            {
                
                return true;
            }
            else
            {
                return false;
            }*/
        }


        public void Print()
        {
            for (int i = 0; i < listik.Count; i++)
                Console.WriteLine(listik[i]);
        }
        public bool Find(T element)
        {
            return listik.Contains(element);
        }
    }
}
