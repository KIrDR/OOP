using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SuperStack<T> : Stack<T> 
        {

        public Stack<T> hh = new Stack<T>(); 

        public void Add(T h)
        {
            this.hh.Push(h);
        }


        public static bool operator ==(SuperStack<T> arr1, SuperStack<T> arr2)
        {
            try
            {
                if(arr1.Count == 0 || arr2.Count == 0)
                {
                    throw new InsufficientExecutionStackException(); 
                }

                return arr1.Count.Equals(arr2.Count);

            }
            catch (InsufficientExecutionStackException e )
            {
                Console.WriteLine("Длина одного из стеков равна нулю ");
            }

            return arr1.Count.Equals(arr2.Count);

        }

        public static bool operator !=(SuperStack<T> arr1, SuperStack<T> arr2)
        {
            try
            {
                if (arr1.Count == 0 || arr2.Count == 0)
                {
                    throw new Exception();
                }

                return !arr1.Count.Equals(arr2.Count);

            }
            catch (Exception e)
            {
                Console.WriteLine("Длина одного из стеков равна нулю ");
            }

            return arr1.Count.Equals(arr2.Count);
        }




    }
}
