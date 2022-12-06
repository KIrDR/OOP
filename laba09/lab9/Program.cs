using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Collections.Concurrent;


namespace lab9
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Books Dystopia = new Books();
            Dystopia.Add("1984", "Джордж Оруэлл");
            Dystopia.Add("О дивный новый мир", "Олдос Хаксли");
            Dystopia.Add("Кысь", "Татьяна Никитична Толстая");
            Dystopia.Add("Бегущий человек", "Стивен Кинг");
            Dystopia.Add("Повелитель мух", "Уильям Голден");
            Dystopia.Add("Вожделеющее семя", "Эноти Бёрджесс");

            Console.WriteLine("\nСписок всех авторов: ");
            foreach (string i in Dystopia.Values)
                Console.WriteLine(i);

            Console.WriteLine("\nСписок всех книг:");
            foreach (string i in Dystopia.Keys)
                Console.WriteLine(i);

            Console.WriteLine("\nКто написал роман-антиутопию под названием 1984?");
            Console.WriteLine(Dystopia["1984"]);

            Dystopia.Remove("Кысь");
            Console.WriteLine("\nСписок книг после удаления Кысь");
            foreach (string i in Dystopia.Keys)
                Console.WriteLine(i);

            Books Drama = new Books();
            Drama.Add("Фауст", "Иоганн Гёте");
            Drama.Add("Беприданница", "Александр Островский");
            Drama.Add("Вишнёвый сад", "Антон Чехов");
            Drama.Add("На дне", "Максим Горький");

            List<Books> Library = new List<Books>();
            Library.Add(Dystopia);
            Library.Add(Drama);

            Console.WriteLine("\n Выводим авторов из библиотеки:  ");
            foreach (Books prod in Library)
            {
                Console.WriteLine(prod[0]);
            }


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

            ObservableCollection<Books> MyColletion = new ObservableCollection<Books>();                //пользовательский интерфейс получает информацию об изменениях коллекции

            MyColletion.CollectionChanged += MyCollection_onChange;

            MyColletion.Add(Dystopia);
            MyColletion[0] = Drama;
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