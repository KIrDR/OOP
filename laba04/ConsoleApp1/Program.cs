namespace Laba03
{

    public class Production
    {
        private readonly string ProductName;
        private readonly int Id;
        private readonly string Department;

        public Production(string name, int id, string department)
        {
            ProductName = name;
            Id = id;
            Department = department;
        }
    }

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

            public Developer(string fullName ,int id, string organization)
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
        
        public static bool operator !=(ArrayN arr1,ArrayN arr2)
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


    static class Program
    {
        static void Main()
        {
            Console.WriteLine("Массив какого размера вы хотите задать?");
            int Size = Convert.ToInt32(Console.ReadLine());

            ArrayN arr = new ArrayN(Size);

            Console.WriteLine("Хотите заполнить массив вручную или случайными значениями?  0/1 ");

            int nn = Convert.ToInt32(Console.ReadLine());

            switch (nn)
            {
                case 0:
                    for (int i = 0; i < arr.Length; i++)
                    {
                        int ReadNumber = Convert.ToInt32(Console.ReadLine());
                        arr.oneArray[i] = ReadNumber;
                    }
                    break;

                case 1:
                    Random ran = new Random();
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = ran.Next(1, 100);
                        Console.Write("{0}\t", arr[i]);
                    }
                    break;
                    default: arr = new ArrayN(nn); 
                    break;
            }

            Console.WriteLine("Какую операцию сравнения хотите выполнить ? \n < - проверка отсутствия элемента \n > - наличие элемента");
            string operation = Console.ReadLine();

            Console.WriteLine("Введите элемент сравления:");
            int nnn = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case ("<"):
                    Console.WriteLine(arr < nnn);  break;

                case (">"):
                    Console.WriteLine(arr > nnn); break;

                default:
                    Console.WriteLine();   break;
            }

            Console.WriteLine("Проверим работу оператора != для массивов\nВведите второй массив");
            Console.WriteLine("Массив какого размера вы хотите задать?");
            int Size2 = Convert.ToInt32(Console.ReadLine());

            ArrayN arr2 = new ArrayN(Size2);

            Console.WriteLine("Хотите заполнить массив вручную или случайными значениями?  0/1 ");

            int nn2 = Convert.ToInt32(Console.ReadLine());

            switch (nn2)
            {
                case 0:
                    for (int i = 0; i < arr2.Length; i++)
                    {
                        int ReadNumber = Convert.ToInt32(Console.ReadLine());
                        arr2.oneArray[i] = ReadNumber;
                    }
                    break;

                case 1:
                    Random ran = new Random();
                    for (int i = 0; i < arr2.Length; i++)
                    {
                        arr2[i] = ran.Next(1, 100);
                        Console.Write("{0}\t", arr2[i]);
                    }
                    break;
                default:
                    
                    break;
            }
            Console.WriteLine("Сравним два массива \n arr1 != arr2 : {0}\n\n\n", arr != arr2);

            Console.WriteLine("Объединение массивов оператором + \n Объединим arr1 и arr2");

            int[] arr3 = arr + arr2 ;
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write("{0}\t", arr3[i]);
            }

            Console.WriteLine("!!!      задание 2      !!!");




            ArrayN.Developer develop = new ArrayN.Developer("Акахекобарович",12,"Мясокомбинат");

            ArrayN Word = new ArrayN();
            Word.developer = develop;


            
        }
    }
}