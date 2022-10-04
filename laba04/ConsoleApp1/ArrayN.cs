using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba03
{
    class ArrayN
    {
        public int[]? oneArray;
        public int? Length;
        public Production? production;
        public Developer? developer;

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
            oneArray = new int[Size];
            Length = Size;
        }
        public void DeveloperInitialization(string name, int id, string department)
        {
            developer = new Developer(name, id, department);
        }
        public ArrayN(Developer developer2, int Size)
        {
            developer = developer2;
        }

        // Создаем простейший индексатор
        public int this[int index]
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

        public static int[] operator +(ArrayN arr1, ArrayN arr2)
        {
            int[] result = arr1.oneArray.Concat(arr2.oneArray).ToArray();
            return result;
        }


        public static bool operator ==(ArrayN arr1, ArrayN arr2)
        {
            if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] == arr2[i])
                    {
                        return true;
                    }
                }
            }
            Console.WriteLine("Массивы не равны по длине !");
            return false;
        }

        public static bool operator !=(ArrayN arr1, ArrayN arr2)
        {



            return !(arr1.oneArray.SequenceEqual(arr2.oneArray));
            /*for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    return false;
                }
            }*/


        }


        public static bool operator >(ArrayN array, int number) // Оператор > выполнит проверку. Если элемент есть в массиве, то TRUE
        {
            foreach (int n in array.oneArray)
            {
                if (n == number)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator <(ArrayN array, int number) // Оператор < выполнит проверку. Если элемента нет в массиве, то TRUE 
        {
            foreach (int n in array.oneArray)
            {
                if (n == number)
                {
                    return false;
                }
            }

            return true;
        }
    }

}
