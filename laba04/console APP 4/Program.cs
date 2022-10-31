
using console_APP_4;

namespace laba04
{

    class Program
    {
        public static void Main()
        {

            Button NiceButton = new Button();

            Checktbox NiceChecBox = new Checktbox();

            Radiobutton NiceRadioButton = new Radiobutton();

            Circle circleButtton = new Circle((float)4.3, (float)4.3, (float)4.3, NiceButton);
            Circle circleCheckBox = new Circle((float)4.3, (float)4.3, (float)4.3, NiceChecBox);
            Circle circleRadioButton = new Circle((float)4.3, (float)4.3, (float)4.3, NiceRadioButton);


            circleButtton.pointX = 5;
            circleButtton.pointY = 4;


            circleCheckBox.pointX = 10;
            circleCheckBox.pointY = 4;


            circleRadioButton.pointX = 12;
            circleRadioButton.pointY = 124;



            circleButtton.Show();
            circleButtton.button.Input();
            circleButtton.button.Tap = true;
            circleButtton.button.Input();

            circleCheckBox.Show();

            ((AbstaractFigure)circleRadioButton).Show();
            circleRadioButton.radoibutton.Input();
            circleRadioButton.radoibutton.Tap = true;
            circleRadioButton.radoibutton.Input();

            Console.WriteLine("Метод из интерфейса: "); 
            ((IManagement)circleRadioButton).Show();
            Console.WriteLine("\n\n\n\nРабота с прямоугольником");

            Rectangle rectangle1 = new Rectangle((float)4.3, (float)4.3, (float)2, (float)7, NiceButton);
            Rectangle rectangle2 = new Rectangle((float)4.3, (float)4.3, (float)2, (float)7, NiceChecBox);
            Rectangle rectangle3 = new Rectangle((float)4.3, (float)4.3, (float)2, (float)7, NiceRadioButton);

            rectangle1.Show();
            rectangle1.ToString();


            Console.WriteLine();


            Console.WriteLine("\n\n\n\nРабота с классом Print");

            var printer = new IManagement[] {rectangle1, rectangle2, rectangle3, circleButtton, circleCheckBox, circleRadioButton };

            foreach(var el in printer)
            {
                 Printer.IAmPrinting(el);
            }

            Console.ReadLine();
            



        }
    }




}

