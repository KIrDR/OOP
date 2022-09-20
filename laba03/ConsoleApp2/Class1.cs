using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programm
{
    public partial class Airlains
    {

        public Airlains(int NofFlight = 0)
        {

        }

        // private Airlains(){}

        public Airlains(string Destinaton, int NofFlight, string TypeFly, DateTime dateTime, string Day)
        {
            this.Destinaton = Destinaton;
            this.NofFlight = NofFlight;
            this.TypeFly = TypeFly;
            this.dateTime = dateTime;
            this.Day = Day;
        }

        public Airlains()
        {

        }


        public static void GoalDestination(Airlains[] x)
        {
            Console.WriteLine("Рейсы к какому пункту назначения вы хотите узнать?");

            string? destination = Console.ReadLine();

            foreach (Airlains dest in x)
            {
                if (destination == dest.Destinaton)
                {
                    Console.WriteLine("{0} {1} {2} {3} {4}", dest.Destinaton, dest.NofFlight, dest.TypeFly, dest.dateTime, dest.Day);
                }
            }
        }


        public static void SelectionOfDay(Airlains[] Air, out string massage)
        {
            massage = "HELLO";

            Console.WriteLine("Рейсы в какой день вы хотите узнать?");

            string? destination = Console.ReadLine();

            foreach (Airlains day in Air)
            {
                if (destination == day.Day)
                {
                    Console.WriteLine("{0} {1} {2} {3} {4}", day.Destinaton, day.NofFlight, day.TypeFly, day.dateTime, day.Day);
                }
            }
        }

        public override bool Equals(object obj)                 //переопределение метода Equals()
        {
            Airlains? temp = obj as Airlains;
            if (temp == null)
                return false;
            return (temp.dateTime == this.dateTime && temp.Day == this.Day && temp.Destinaton == this.Destinaton && temp.NofFlight == this.NofFlight && temp.TypeFly == this.TypeFly);
        }

        public override int GetHashCode()                       //переопределение метода GetHashCode()
        {
            Console.WriteLine("Вызвался переопределенный метод GetHashCode");
            return 1;
        }

        public override string ToString()                       //переопределение метода ToString()
        {
            return ($"Пункт назначения: {this.Country}, День недели: {this.Day}, Номер рейса: {this.NofFlight}, Тип самолёта: {this.TypeFly}");
        }

        static int Number;

        static Airlains()
        {

        }

        public static void PrintList(ref Airlains[] x)
        {
            foreach (Airlains xz in x)
            {
                Console.WriteLine("{0}  {1}  {2}  {3}  {4}", xz.Destinaton, xz.NofFlight, xz.TypeFly, xz.dateTime, xz.Day);
            }

        }
    }
}
