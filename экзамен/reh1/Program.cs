// 3-21 

using System;

namespace reh1
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("ksmfvomdofv");
            var Pasha = new Stud("Pasha",3,2,Spec.isit,10,9,10);
            var Anton = new Stud("Anton", 6, 1, Spec.mobile, 10, 9, 10);

            var Maksim = new Stud("Maksim", 5, 2, Spec.poit, 8, 4, 7);

            var Kirill = new Stud("Kirill", 3, 2, Spec.poit, 6, 2, 1);

            var Dima = new Stud("Dima", 3, 2, Spec.isit, 5, 3, 9);

            Console.WriteLine();
            Pasha.Print();
            Pasha.PrintEnum();

            Pasha.Kortej();
            var Isit2 = new Group();
            Isit2.Add(Pasha);
            Isit2.Add(Anton);
            Isit2.Add(Maksim);
            Isit2.Add(Kirill);
            Isit2.Add(Dima);

            Isit2.Print();


            var result = (from a in Isit2.Stud
                                       where a.spec == Spec.isit
                                       select a);

            var result2 = Isit2.Stud.OrderBy(s => (s.math+s.OOP+s.dataBase)/3);
            Console.WriteLine(result2);

            var result3 = from b in Isit2.Stud
                          where b.spec == Spec.isit
                          orderby Math.Min(Math.Min(b.OOP,b.math),b.dataBase)
                          select b;
            Console.WriteLine("Минимальная оценка студентов специальности ИСИТ");
            var c = result3.First();
            Console.WriteLine(Math.Min(Math.Min(c.OOP, c.math), c.dataBase));


            var result4 = from b1 in Isit2.Stud
                          where b1.spec == Spec.poit
                          orderby Math.Min(Math.Min(b1.OOP, b1.math), b1.dataBase)
                          select b1;
            Console.WriteLine("Минимальная оценка студентов специальности ПОИТ");
            var п = result4.First();
            Console.WriteLine(Math.Min(Math.Min(п.OOP, п.math), п.dataBase));

            var result5 = from b2 in Isit2.Stud
                          where b2.spec == Spec.mobile
                          orderby Math.Min(Math.Min(b2.OOP, b2.math), b2.dataBase)
                          select b2;
            Console.WriteLine("Минимальная оценка студентов специальности МОБИЛКА");
            var o = result5.First();
            Console.WriteLine(Math.Min(Math.Min(o.OOP, o.math), o.dataBase));

            var Poit = new Group(); 

            try
            {
                Isit2.Clearn();
                Poit.Clearn();

            }
            catch (Exception e)
            {
                Console.WriteLine("Группа уже пуста !! !");
            }

        }
    }
}