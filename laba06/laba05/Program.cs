
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
                Debugger.Break(); 
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