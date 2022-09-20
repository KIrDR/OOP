using System;


namespace Programm
{

    public partial class Airlains
    {
        private readonly string Destinaton;
        private readonly int NofFlight;
        private string TypeFly;
        private DateTime dateTime;
        private string Day;

        public string Country                       //общедоступные свойства
        {
            get { return this.Country; }
            private set { this.Country = value; }
        }

        public int Flight
        {
            get { return this.NofFlight; }        //ограничили доступ по set, т.е. свойство доступно только для чтения
        }

        public string Airplane
        {
            get { return this.TypeFly; }
            set { this.TypeFly = value; }
        }

        public DateTime Flight_Time
        {
            get { return this.dateTime; }
            private set { this.dateTime = value; }
        }
        public string Day_of_week
        {
            get { return this.Day; }
            set { this.Day = value; }
        }

    }

    public static class Program
    {
        public static void Main()
        {

            string massage = "HI";


            var flight = new { destination = "Ghonkong", NofFlight = 1, TypeFly = "Boeing777", dateTime = new DateTime(2021, 09, 03), Day = "Воскресенье" };

            Airlains[] reys = new Airlains[13] {new Airlains("Moskow", 1, "boeng3777", new DateTime(2022, 09, 28, 19, 00, 00), "Mondeay"),
                                                new Airlains("New-York", 2, "boeng31427", new DateTime(2022, 12, 08, 01, 30, 00), "Tusday"),
                                                new Airlains("Minsk", 3, "boeng77", new DateTime(2022, 10, 08, 05, 00, 00), "Wednesday"),
                                                new Airlains("Sochi", 4, "boeng377", new DateTime(2023, 05, 28, 13, 00, 00), "Friday"),
                                                new Airlains("Berlin", 5, "boeng377", new DateTime(2023, 05, 28, 13, 00, 00), "Thursday"),
                                                new Airlains("Sochi", 6, "boeng377", new DateTime(2023, 12, 28, 13, 00, 00), "Monday"),
                                                new Airlains("Moskow", 7, "boeng377", new DateTime(2023, 02, 28, 13, 00, 00), "Friday"),
                                                new Airlains("Minsk", 8, "boeng377", new DateTime(2023, 07, 28, 13, 00, 00), "Thursday"),
                                                new Airlains("Sochi", 9, "boeng377", new DateTime(2023, 11, 28, 13, 00, 00), "Monday"),
                                                new Airlains("Moskow", 10, "boeng377", new DateTime(2023, 05, 28, 13, 00, 00), "Friday"),
                                                new Airlains("LA", 11, "boeng377", new DateTime(2023, 05, 28, 13, 00, 00), "Thursday"),
                                                new Airlains("Sochi", 12, "boeng377", new DateTime(2023, 05, 28, 13, 00, 00), "Thursday"),
                                                new Airlains("Praga", 13, "boeng37", new DateTime(2024, 03, 18, 14, 00, 00), "Friday")};

            Airlains.PrintList(ref reys);
            Airlains.GoalDestination(reys);
            Airlains.SelectionOfDay(reys, out massage);
        }
    }
}