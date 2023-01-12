namespace reh4
{
    class Program
    {
        async public static void Print()
        {
            await Task.Run(
                () =>
                {
                    int i = 1;
                    while (i < 10000)
                    {
                        Console.WriteLine(i);
                        i++;
                    }
                });
        }


        public static void Main()
        {
            Print();
            Console.WriteLine("ГОЛОВАЧ");
            Console.ReadKey();
        }
    }
}