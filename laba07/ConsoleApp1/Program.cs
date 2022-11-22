using ConsoleApp1;

namespace Laba03
{

   

    static class Program
    {
        static void Main()
        {
            try
            {
                string[] array = { "HI ", "My name is " };
                ArrayN<string> word = new ArrayN<string>(array);
                ((IGenericInterface<string>)word).Show();
                ((IGenericInterface<string>)word).Add("Pavel");
                ((IGenericInterface<string>)word).Show();

                IGenericInterface<string> sdf  = word;
                sdf.Show();


                ((IGenericInterface<string>)word).Delete(1,2);
                ((IGenericInterface<string>)word).Show();
                ((IGenericInterface<string>)word).Delete(0, 1);


                int[] intarray = {1, 1 };
                ArrayN<int> numbers = new ArrayN<int>(intarray);

                ((IGenericInterface<int>)numbers).Show();


                double[] doublearray = { 1.364456456, 1.148258 };

                ArrayN<double> numbersReal = new ArrayN<double>(doublearray);


                ((IGenericInterface<double>)numbersReal).Show();


                Button button = new Button();
                Checktbox checktbox1 = new Checktbox();
                Radiobutton radiobutton1 = new Radiobutton();
                Circle circle1 = new Circle(2,5,7,button);
                Circle circle2 = new Circle(2, 5, 7, button);

                Rectangle rectangle1 = new Rectangle(1,5,8,1,checktbox1);

                Circle[] penis = {circle1, circle2 };
                ArrayN<Circle> UserFigure = new ArrayN<Circle>(penis);
                ((IGenericInterface<Circle>)UserFigure).Show();
                ((IGenericInterface<Circle>)UserFigure).Add(circle1);
                ((IGenericInterface<Circle>)UserFigure).Show();
                ((IGenericInterface<Circle>)UserFigure).Delete(0,2);

                ArrayN<int>.WriteToFile(ref numbers);


                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine("Часть 1. Конец ");
            }
        }
    }
}