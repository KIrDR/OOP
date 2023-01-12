using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reh1
{
    public enum Spec 
    {
        poit = 1 , 
        isit,
        mobile 
    }
    public class Stud
    {
        public string name;
        public int numbGroup;
        public int cours;
        public Spec spec;
        public int OOP;
        public int dataBase;
        public int math;


        public void Kortej()
        {
            (int,int,float) g = (Math.Min(Math.Min(OOP,dataBase),math), Math.Max(Math.Max(OOP, dataBase), math), (float)(OOP+dataBase+math)/3);
            Console.WriteLine($"Минимальная оценка : {g.Item1}");
            Console.WriteLine($"Максимальная оценка : {g.Item2}");
            Console.WriteLine($"Средняя оценка :  {g.Item3}"  );
            Console.WriteLine(g);
        }

        public void Print()
        {
            Console.WriteLine($"{name}, {numbGroup}, {cours}, {spec}, {OOP}, {dataBase}, {math}");
        }


        public void PrintEnum()
        {
            Console.WriteLine($"{name}, {numbGroup}, {cours}, {(int)spec},  {OOP}, {dataBase}, {math}");
        }


        public Stud(string name, int numb,int cours, Spec spec, int datdBase, int OOP, int math)
        {
            this.name = name;
            this.numbGroup = numb;
            this.cours = cours;
            this.spec = spec;
              this.dataBase = datdBase;
            this.OOP = OOP;
            this.math = math;
        }


    }
}
