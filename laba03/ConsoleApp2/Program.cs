using System;


namespace Programm
{
    public class Airlains
    {
        private readonly string Destinaton;
        private readonly int NofFlight;
        private readonly string TypeFly;
        private readonly DateTime dateTime;
        private readonly string Day;

        public Airlains(string Destinaton, int NofFlight, string TypeFly, DateTime dateTime, string Day)
        {
            this.Destinaton = Destinaton;
            this.NofFlight = NofFlight;
            this.TypeFly = TypeFly;
            this.dateTime = dateTime;
            this.Day = Day;
        }

       public static void GoalDestination(Airlains[] x)
        {
            Console.WriteLine("Рейсы к какому пункту назначения вы хотите узнать?");

            string? destination = Console.ReadLine();

            foreach ( Airlains dest in x)
            {
                if( destination == dest.Destinaton)
                {
                    Console.WriteLine("{0} {1} {2} {3} {4}", dest.Destinaton, dest.NofFlight, dest.TypeFly, dest.dateTime, dest.Day);
                }
            }
        }


        public static void SelectionOfDay(Airlains[] Air)
        {
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

       public static void  PrintList(Airlains[] x)
        {
            foreach (Airlains xz in x)
            {
                Console.WriteLine("{0}  {1}  {2}  {3}  {4}",xz.Destinaton, xz.NofFlight, xz.TypeFly, xz.dateTime, xz.Day);
            }

        }

    }

    public static class Program
    {
        public static void Main()
        {

       


            Airlains[] reys = new Airlains[13] { new Airlains("Moskow", 1, "boeng3777", new DateTime(2022, 09, 28, 19, 00, 00), "Mondeay"),
                                                new Airlains("New-York", 2, "boeng31427", new DateTime(2022, 12, 08, 01, 30, 00), "Tusday"),
                                                new Airlains("Minsk", 3, "boeng77", new DateTime(2022, 10, 08, 05, 00, 00), "Wednesday"),
                                                new Airlains("Sochi", 4, "boeng377", new DateTime(2023, 05, 28, 13, 00, 00), "Friday"),
                                                new Airlains("Berlin", 5, "boeng377", new DateTime(2023, 05, 28, 13, 00, 00), "Thursday"),
                                                new Airlains("Sochi", 6, "boeng377", new DateTime(2023, 05, 28, 13, 00, 00), "Monday"),
                                                new Airlains("Moskow", 7, "boeng377", new DateTime(2023, 05, 28, 13, 00, 00), "Friday"),
                                                new Airlains("Minsk", 8, "boeng377", new DateTime(2023, 05, 28, 13, 00, 00), "Thursday"),
                                                new Airlains("Sochi", 9, "boeng377", new DateTime(2023, 05, 28, 13, 00, 00), "Monday"),
                                                new Airlains("Moskow", 10, "boeng377", new DateTime(2023, 05, 28, 13, 00, 00), "Friday"),
                                                new Airlains("LA", 11, "boeng377", new DateTime(2023, 05, 28, 13, 00, 00), "Thursday"),
                                                new Airlains("Sochi", 12, "boeng377", new DateTime(2023, 05, 28, 13, 00, 00), "Thursday"),
                                                new Airlains("Praga", 13, "boeng37", new DateTime(2024, 03, 18, 14, 00, 00), "Friday")};

            Airlains.PrintList(reys);
            Airlains.GoalDestination(reys);
            Airlains.SelectionOfDay(reys);
        }
    }
}