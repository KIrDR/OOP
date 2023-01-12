using System.Drawing;
using System.Xml;
using System.Xml.Linq;
using static lab13.CustomSerializer;

namespace lab13
{
    public class Program
    {
        [Obsolete("Obsolete")]
        public static void Main()
        {
            var humanArray = new Human[2];
            humanArray[0] = new Human("Vasya", DateTime.Now, "man");
            humanArray[1] = new Human("Marta", DateTime.Now, "girl");

            var rectangleA = new Rectangle[2] {new Rectangle(2,3,4,1),new Rectangle(5,62,1,4)};

            Serialize("rectangleA.bin", rectangleA);
            Serialize("rectangleA.xml", rectangleA);
            Serialize("rectangleA.json", rectangleA);

            Deserialize("rectangleA.bin");
            Deserialize("rectangleA.xml");
            Deserialize("rectangleA.json");

            var xDoc = new XmlDocument();
            xDoc.Load("rectangleA.xml");
            var xRoot = xDoc.DocumentElement;

            Console.WriteLine("\n");
            var nodes = xRoot?.SelectNodes("Rectangle");
            if (nodes is not null)
            {
                foreach (XmlNode node in nodes)
                    Console.WriteLine(node.OuterXml);
            }
            
            Console.WriteLine("\n");

            nodes = xRoot?.SelectNodes("Rectangle/X");
            if (nodes is not null)
            {
                foreach (XmlNode node in nodes)
                    Console.WriteLine(node.OuterXml);
            }

            var doc = XDocument.Load("rectangleA.xml");
            var items = from item in doc.Element("ArrayOfRectangle").Elements("Rectangle")
                        where item.Element("X").Value == "2"
                        select new Rectangle(Convert.ToInt32(item.Element("X").Value), 23, 1, 5);

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
