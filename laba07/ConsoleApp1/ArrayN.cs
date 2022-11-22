using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba03
{
    public class ArrayN <T> : IGenericInterface<T> 
    {
        

        public T[]? oneArray;
        public int? Length;
        public Production? production;
        public Developer? developer;

        public ArrayN(T[] value)
        {
            oneArray = value ;
        }
        public void ProductionInitialization(string name, int id, string department)
        {
            production = new Production(name, id, department);
        }

        public class Developer
        {
            public string? FullName;
            public int Id;
            public string? Department;

            public Developer(string fullName, int id, string organization)
            {
                FullName = fullName;
                Id = id;
                Department = organization;
            }
        }

        public ArrayN()
        {

        }

        public ArrayN(int Size)
        {
            oneArray = new T[Size];
            Length = Size;
        }
        public void DeveloperInitialization(string name, int id, string department)
        {
            developer = new Developer(name, id, department);
        }

        void IGenericInterface<T>.Show()
        {
            foreach (var e in oneArray)
            {
                Console.Write(e + " ");
            }
            Console.WriteLine();
        }

        void IGenericInterface<T>.Delete(int index, int quantity)
        {
            if (quantity > this.oneArray.Length - index)
            {
                throw new ExceptionRange() ; 
            }
           Array.Clear(oneArray, index, quantity);
        }

        void IGenericInterface<T>.Add(T e)
        {

            T[] mamam = {e};

            oneArray = oneArray.Concat(mamam).ToArray();

        }

        public ArrayN(Developer developer2, int Size)
        {
            developer = developer2;
        }

        // Создаем простейший индексатор
        public T this[int index]
        {
            set
            {
                oneArray[index] = value;
            }

            get
            {
                return oneArray[index];
            }
        }

        public static T[] operator +(ArrayN<T> arr1, ArrayN<T> arr2)
        {
            T[] result = arr1.oneArray.Concat(arr2.oneArray).ToArray();
            return result;
        }

        public static bool operator ==(ArrayN<T> arr1, ArrayN<T> arr2)
        {
            if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (!arr1[i].Equals(arr2[i]) )
                    {
                        return false;
                    }
                }
                return true;

            }
            else
            {
                Console.WriteLine("Массивы не равны по длине !");
                return false;
            }
        }

        public static bool operator !=(ArrayN<T> arr1, ArrayN<T> arr2)
        {

            return !(arr1.oneArray.SequenceEqual(arr2.oneArray));
   
        }


        public static bool operator >(ArrayN<T> array, T number) // Оператор > выполнит проверку. Если элемент есть в массиве, то TRUE
        {
            foreach (var n in array.oneArray)
            {
                if (n.Equals(number))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator <(ArrayN<T> array, T number) // Оператор < выполнит проверку. Если элемента нет в массиве, то TRUE 
        {
            foreach (T n in array.oneArray)
            {
                if (n.Equals(number))
                {
                    return false;
                }
            }

            return true;
        }
        public static void WriteToFile(ref ArrayN<T> arr)
        {
            using (var file = new StreamWriter(@"..\..\..\log.txt", true))
            {
                foreach (var item in arr.oneArray)
                {
                    file.Write($"{item}\n");
                }
            }
        }

        public static void ReadFromFile()
        {
            using (var file = new StreamReader(@"..\..\..\log.txt", true))
            {
                Console.WriteLine(file.ReadToEnd());
            }
        }
    }

}
