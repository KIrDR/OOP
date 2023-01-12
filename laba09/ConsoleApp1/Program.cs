
using static System.Reflection.Metadata.BlobBuilder;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace ConsoleApp1

{
    class Program
    {
        public static void Main()
        {
            Book<int,string> shelf1 = new Book<int,string>() ;

            shelf1.Add(1,"Азбука");
            shelf1.Add(2,"Букварь");
            shelf1.Add(3,"Журнал об охоте");
            shelf1.Add(4,"Биология 9 класс");
            shelf1.Add(5,"С# для дошкольников");
            shelf1.Add(6,"pascal. Школьное пособие ");
            shelf1.Add(7,"Рыбалка на дому ");
            shelf1.Add(8,"Головач ");
            shelf1.Add(9,"Красная ШАПКА");

            foreach(var i in shelf1.Keys)
            {
                Console.WriteLine(i);   
            }

            Console.WriteLine("название всех книг на полке 1");
            foreach(var i in shelf1.Values) 
            { Console.WriteLine(i); }

            Console.WriteLine("номера и книги");
            for (var i = 1; i <= shelf1.Count; i++)
            {
                Console.WriteLine($"{i} \t {shelf1[i]}");
            }

            shelf1.Remove(4);
            foreach (var i in shelf1.Keys)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("название всех книг на полке 1");
            foreach (var i in shelf1.Values)
            { Console.WriteLine(i); }


            Book<int,string> shelf2 = new Book<int, string>() { { 1,"Пожилой"},{ 2, "Гуляй" }, {3,"Дядя" }  } ;


            //2. Создаём обобщенную коллекцию и заполняем ее данными
            ConcurrentBag<int> nums = new ConcurrentBag<int>();             // В случае выбора ConcurrentBag мы получаем гарантию, что код не упадёт в многопоточной работе. 
                                                                            // Порядок не имеет значения

            for (int i = 0; i < 20; i++) nums.Add(i);                       // добавление элементов в коллекцию
            Console.WriteLine("\nЭлементы первой коллекции до изменения:");
            foreach (int a in nums)
                Console.WriteLine(a);

            int n;
            for (int i = 0; i < 4; i++)
            {
                nums.TryTake(out n);                                        // удаление элементов из коллекции
                Console.WriteLine(n);
            }

            Console.WriteLine("\nЭлементы первой коллекции после изменения:");
            foreach (int a in nums)
                Console.WriteLine(a);

            // Создание второй коллекции и зарполнение её элементами предыдущей коллекции

            List<int> nums2 = new List<int>();

            while (!nums.IsEmpty)
            {
                if (nums.TryTake(out n))
                {
                    nums2.Add(n);
                }
            }

            Console.WriteLine("\nЭлементы второй коллекции:");
            foreach (int a in nums2)
                Console.WriteLine(a);

            if (nums2.Contains(11)) Console.WriteLine("\nnums2 содержит '11'");
            else Console.WriteLine("\nnums2 не содержит '11'");

            //3. Создайте объект наблюдаемой коллекции ObservableCollection<T>. 
            //Создайте произвольный метод и зарегистрируйте его на событие CollectionChange. 
            //Напишите демонстрацию с добавлением и удалением элементов. В качестве типа T используйте свой класс из таблицы.

            ObservableCollection<Book<int,string>> MyColletion = new ObservableCollection<Book<int, string>>();                //пользовательский интерфейс получает информацию об изменениях коллекции

            MyColletion.CollectionChanged += MyCollection_onChange;

            MyColletion.Add(shelf1);
            MyColletion[0] = shelf2;
            MyColletion.RemoveAt(0);
        }

        private static void MyCollection_onChange(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Console.WriteLine("Добавлен элемент в коллекцию MyCollection");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Console.WriteLine("Удалён элемент в коллекцию MyCollection");
                    break;
                case NotifyCollectionChangedAction.Replace:
                    Console.WriteLine("Изменен элемент в коллекцию MyCollection");
                    break;
            }
        }

    }
    }
