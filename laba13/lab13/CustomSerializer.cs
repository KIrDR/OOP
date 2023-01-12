using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;
//using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

namespace lab13
{

    [Serializable]
    public static class CustomSerializer
    {
        [Obsolete("Obsolete")]
        public static void Serialize(string file, Rectangle[] human)
        {
            var format = file.Split('.').Last();
            switch (format)
            {
                case "bin":
                    var bf = new BinaryFormatter();
                    using (var fs = new FileStream(file, FileMode.OpenOrCreate))
                    {
                        bf.Serialize(fs, human);
                    }

                    break;

                /*case "soap":
                    SoapFormatter sf = new SoapFormatter();
                    using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
                    {
                        sf.Serialize(fs, human);
                    }

                    break;*/

                case "xml":
                    var xs = new XmlSerializer(typeof(Rectangle[]));
                    using (var fs = new FileStream(file, FileMode.OpenOrCreate))
                    {
                        xs.Serialize(fs, human);
                    }

                    break;

                case "json":
                    var js = new DataContractJsonSerializer(typeof(Rectangle[]));
                    using (var fs = new FileStream(file, FileMode.OpenOrCreate))
                    {
                        js.WriteObject(fs, human);
                    }
                    break;
            }
        }

        [Obsolete("Obsolete")]
        public static void Deserialize(string file)
        {
            var format = file.Split('.').Last();
            switch (format)
            {
                case "bin":
                    var bf = new BinaryFormatter();
                    using (var fs = new FileStream(file, FileMode.Open))
                    {
                        var human = (Rectangle[])bf.Deserialize(fs);
                        foreach (var h in human)
                        {
                            Console.WriteLine($"Deserialized comp: {h.X} {h.Y} {h.Height} {h.Width}");
                        }
                    }

                    break;

                /*case "soap":
                    SoapFormatter sf = new SoapFormatter();
                    using (FileStream fs = new FileStream(file, FileMode.Open))
                    {
                        Human human = (Human)sf.Deserialize(fs);
                    }

                    break;*/

                case "xml":
                    var xs = new XmlSerializer(typeof(Rectangle[]));
                    using (var fs = new FileStream(file, FileMode.Open))
                    {
                        var human = (Rectangle[])xs.Deserialize(fs)!; 
                        foreach (var h in human)
                        {
                            Console.WriteLine($"Deserialized comp: {h.X} {h.Y} {h.Height} {h.Width}");
                        }
                    }

                    break;

                case "json":
                    var js = new DataContractJsonSerializer(typeof(Rectangle[]));
                    using (var fs = new FileStream(file, FileMode.Open))
                    {
                        var human = (Rectangle[])js.ReadObject(fs)!; 
                        foreach (var h in human)
                        {
                            Console.WriteLine($"Deserialized comp: {h.X} {h.Y} {h.Height} {h.Width}");
                        }
                    }

                    break;
            }
        }
    }
}
