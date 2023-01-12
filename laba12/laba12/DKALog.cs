using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba12
{
    public static class DKALog
    {
        public static StreamWriter logfile;

        public static void WriteToLog(string action, string fileName = "", string path = "")
        {
            using (logfile = new StreamWriter(@"G:\Программы малышей\ЛабораторныеРаботы\OOP\laba12\laba12\DKALogfile.txt", true))
            {
                DateTime time = new DateTime();
                time = DateTime.Now;
                logfile.WriteLine("********************************\n");
                logfile.WriteLine($"Действие: {action}");

                if (fileName.Length != 0)
                    logfile.WriteLine($"Имя файла: {fileName}");

                if (path.Length != 0)
                    logfile.WriteLine($"Путь: {path}");

                logfile.WriteLine($"Время: {time.ToLocalTime()}\n");
            }

        }

        public static void SearchByDate(DateTime date)
        {
            using (var reader = new StringReader(File.ReadAllText(@"G:\Программы малышей\ЛабораторныеРаботы\OOP\laba12\laba12\DKALogfile.txt")))
            {
                var lines = reader.ReadToEnd().Split("********************************\n");
                foreach (var line in lines)
                {
                    if (line.Contains(date.ToString()))
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}
