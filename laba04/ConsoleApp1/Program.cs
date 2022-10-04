namespace Laba03
{

   

    static class Program
    {
        static void Main()
        {
            var str = "абаба.йюйцбуйцъдвфвйаюие";
            str.DeleteAllVowel();



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

            Console.WriteLine("\n!!!      задание 2      !!!\n");


            Console.WriteLine("Проверим работу методов расширения");

            Console.WriteLine("Сумма элементов массива arr ");
            arr.Ssum();

            Console.WriteLine("Максимальный элемент");
            arr.Mmax();

            Console.WriteLine("Минимальный элемент");
            arr.Mmin();

            Console.WriteLine("Мах - Min");
            arr.MmaxMinusMmin();


            ArrayN.Developer develop = new ArrayN.Developer("Акахекобарович",12,"Мясокомбинат");

            ArrayN Word = new ArrayN();
            Word.developer = develop;

            Console.WriteLine(Word.developer.FullName);

           // Word.DeleteAllVowel();



        }
    }
}