
using laba05;
using System.Diagnostics;

namespace laba05
{

    class Program
    {
        public static void Main()
        {

            /*

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
            */


            Button NiceButton = new Button();

            Checktbox NiceChecBox = new Checktbox();

            Radiobutton NiceRadioButton = new Radiobutton();


            // 1 
            try
            {



                var circle1 = new Circle((float)4.3, (float)4.3, (float)4.3, NiceButton, 7); 

                circle1.Show();
            }
            catch (InvalidTypeException e)
            {
                Logger.Log(e, true, true);
            }
            finally
            {
                Console.WriteLine("end try-catch-finally\n\n");
            }

            //2 
            try
            {
                var circle2 = new Circle((float)4.3, (float)4.3, (float)12, NiceButton, 1,200,44,7);
                 

                circle2.Show();

                int x = 0; 

                Console.WriteLine(circle2.color.red / x);

            }

            
            catch (Exception e)
            {
                Logger.Log(e, true, true);
            }
            
            
            finally
            {
                Console.WriteLine("end try-catch-finally\n\n");
            }

            // 3 



            try
            {
                var circle2 = new Circle((float)4.3, (float)4.3, (float)-12, NiceButton, 1, 200, 44, 7);


                circle2.Show();

                int x = 0;

                Console.WriteLine(circle2.color.red / x);

            }


            catch (InvalidTypeException e)
            {
                Logger.Log(e, true, true);
            }


            finally
            {
                Console.WriteLine("end try-catch-finally\n\n");
            }


            // 4 

            try
            {
                var rectangle1 = new Rectangle((float)4.3, (float)4.3, (float)2.2, (float)-7.4, NiceButton); 
            }

            catch (InvalidTypeException e)
            {
                Logger.Log(e, true, true);
            }

            finally
            {
                Console.WriteLine("end try-catch-finally\n\n");
            }

            // 5 

            try
            {
                var rectangle2 = new Rectangle((float)-4.3, (float)4.3, (float)2.2, (float)-7.4, NiceButton);
            }

            catch (InvalidTypeException e)
            {
                Logger.Log(e, true, true);
            }

            catch (InvalidPositionException e)
            {
                Logger.Log(e, true, true);
            }


            finally
            {
                Console.WriteLine("end try-catch-finally\n\n");
            }

            // вынес исключение в main  


            int[] arr = { 1, 2, 3, 4, 5 }; // массив размером 5
            try
            {
                var length = 10;
                Debug.Assert(length == arr.Length, "Check");

                if (length > arr.Length) throw new IndexOutOfRangeException("with this length will be out of range arr!");
                for (var i = 0; i < length; i++)
                    arr[i] += arr[i];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("\n\tError");
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine("-> Locate Exception: {0}", ex.TargetSite);

            }
            finally
            {
                Console.WriteLine("end try-catch-finally\n\n");
            }


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