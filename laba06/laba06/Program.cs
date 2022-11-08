

namespace laba05
{

    class Program
    {
        public static void Main()
        {

            try
            {
                try
                {
                    var transformer = new Transformer(12, "131", DateTime.Now, 123, (EnumTypesOfTransformers)5);
                    Console.WriteLine(transformer.Energy);
                }
                catch (InvalidTypeException e)
                {
                    Logger.Log(e, true, true);
                }
                finally
                {
                    Console.WriteLine("end try-catch-finally\n\n");
                }

            }

            catch
            {

            }
          
            Console.ReadLine();
        }
    }


    /*
                bool b = true;
                bool c = true;
                while (b) { 
                    Console.WriteLine("Какой объект хотите сосздать? ( 1 - кнопку, 2 - RadioButton, 3 - CheckBox) \n");
                string theButton = Console.ReadLine();
                switch (theButton)
                {
                    case ("1"):
                        Button button = new Button();
                            b = !b;
                            break;
                    case ("2"):
                        Radiobutton radioButton = new Radiobutton();
                            b = !b;
                            break;
                    case ("3"):
                        Checkbox checkboxButton = new Checkbox();
                            b = !b;
                            break;
                    default:
                        Console.WriteLine("неверный ввод/т\n задайте значение верно");
                        break;
                }
                }
                while (c)
                {
                    Console.WriteLine("Какой формы будет объект? ( 1 - круг, 2 - прямоугольник) \n");
                    string theFigure = Console.ReadLine();
                    switch (theFigure)
                    {
                        case ("1"):
                            Circle button = new Circle();
                            c = !c;
                            break;
                        case ("2"):
                            Rectangle radioButton = new Rectangle();
                            c = !c;
                            break;
                        default:
                            Console.WriteLine("неверный ввод/т\n задайте значение верно");
                            break;
                    }
                }*/

}












/*while (true)
          {
              Console.WriteLine("/////// ПРИВЕТ //////\n");

              bool cheker = true;
              while (cheker)
              {
                  Console.WriteLine("Какой объект хотите сосздать? ( 1 - кнопку, 2 - RadioButton, 3 - CheckBox) \n");
                  string theButton = Console.ReadLine();
                  Console.WriteLine("Какой формы будет объект? ( 1 - круг, 2 - прямоугольник) \n");
                  string theFigure = Console.ReadLine();


                  string choise = Console.ReadLine();
                  switch (theButton)
                  {
                      case "1":
                          Button niceButton = new Button();
                          switch (theFigure)
                          ;
                          break;
                      case "2":

                  }


              }

          }*/