
using System.Reflection;

namespace laba11
{
    class Program
    {
        public static void Main()
        {
            //Reflector.OutAssemblyName("Airlains");
            //Reflector.OutPublicConstructors("Airlains");
            //Reflector.OutPublicMethods("Airlains");
            //Reflector.MethodForType("Airlains");
            //Reflector.OutInterfaces("Airlains");
            //Reflector.OutMethodsWithParm("Airlains", "String");
            //Reflector.Voke("laba11.Airlains", "CreateNewAirlains");

            //object[] ls = { "masterchieflast" };
            //var ts1 = Reflector.Create("Airlains", ls);

            //Reflector.file.Close();


            Reflector.Voke("laba11.Airlains", "CreateNewAirlains");

        }
    }
}