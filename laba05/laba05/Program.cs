
using laba05;
using System.Diagnostics;

namespace laba05
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



            UI userInterface = new UI();

            userInterface.Add(circleButtton);
            userInterface.Add(circleCheckBox);
            userInterface.Add(circleRadioButton);
            userInterface.Add(rectangle3);
            userInterface.Add(rectangle1);
            userInterface.Add(rectangle2);

            ControllerUI controlPanel = new ControllerUI();



            controlPanel.Print(userInterface);

            controlPanel.Leng(userInterface);


            Debugger.Break();


            Circle redCircle = new Circle((float)4.3, (float)4.3, (float)4.3, NiceButton, 1);
            Circle greenCircle = new Circle((float)4.3, (float)4.3, (float)4.3, NiceButton, 2);
            Circle blueCircle = new Circle((float)4.3, (float)4.3, (float)4.3, NiceButton, 3);
            Circle blackCircle = new Circle((float)4.3, (float)4.3, (float)4.3, NiceButton, 0);
            Circle whiteCircle = new Circle((float)4.3, (float)4.3, (float)4.3, NiceButton, 16581375);

            redCircle.Show();
            greenCircle.Show();
            blueCircle.Show();
            blackCircle.Show();
            whiteCircle.Show();

            Circle circle = new Circle((float)4.3, (float)4.3, (float)4.3, NiceButton,1, 24 ,2 ,4);

            circle.Show();

            Console.ReadLine();
        }
    }




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