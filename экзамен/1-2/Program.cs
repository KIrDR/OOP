using _1_2;

namespace reh4
{
    class Program
    {
        public static void Main()
        {
            var misha = new Address("Михаил евгенич", " Дщвыаы@оатмотам.com"); 
            var gleb = new Address("Глеб Мирный", " Дщвыаы@оатмм.ru");

            var present = new Letter("Z", "Привет друг ", misha, gleb , "zzz");
            var leter = new Letter("Z", "Пока ", gleb, misha, "zzz");

            present.Print();
            Console.WriteLine();
            leter.Print();

            Console.WriteLine(present.Equals(leter));


            var box = new Box();

            box.Add(present);
            box.Add(leter);
            box.Add(present);
            box.Add(leter);
            box.Add(present);
            box.Add(leter);
            for (int i = 0; i < box.list.Count; i++)
            {
                for (int j = i+1; j < box.list.Count; j++)
                {
                    if (box.list[i].Equals(box.list[j]))
                    {
                        Console.Write(box.list[i].Equals(box.list[j]));
                    
                    }
                    break;
                }
                break;
            }

            var result = from p in box.list
                         where p.addressTo.email == " Дщвыаы@оатмм.ru"
                         select p;

            foreach (var item in result)
            {
                Console.WriteLine(item.Text);
            }
            //Action<object> action = (object letter) =>
            //{
            //    if(letter is Letter)
            //    {
            //        var t = (Letter)letter;
            //        t.Read();
            //    }
            //};

            //foreach (var t in box.list)
            //{
            //    Task t12 = new Task(action,t);
            //    t12.Start();

            //    t12.Wait();
            //}


            foreach( var jj in box.list)
            {
                Task t24 = new Task(jj.Read);
                t24.Start();
                t24.Wait();
            }

            /*foreach (var t in box.list)
            {
                Task t1 = new Task(action,t);
            }*/


            /*Task task = Task.Run(
                () => { var h = new Box(); });*/

        }
    }
}