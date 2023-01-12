using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace console_APP_4
{
    [Serializable]
    public class Rectangle : AbstaractFigure, IManagement
    {
        public float width; 
        public float height;
        public Button? button;
        public Checktbox? checkbutton;

        Button superButton = new Button();

        public Rectangle(float pointX, float pointY,float width, float height, IManagement button)
        {
            this.pointX = pointX;
            this.pointY = pointY;
            this.width = width;
            this.height = height;
            Button niceButton1 = button as Button;
            this.button = niceButton1;
            if (this.button == null)
            {
                Checktbox niceButton2 = button as Checktbox;
                this.checkbutton = niceButton2;
                if (this.button == null)
                {
                    Radiobutton radioButton1 = button as Radiobutton;
                    if (radioButton1 != null)
                    {
                        Console.WriteLine("Прямоугольник не может быть RadioButton");
                    }
                }
            }
        }

        public override void Show()
        {
            Console.WriteLine("\n\n\n");

            if (this.button != null)
            {
                this.button.Show();
            }
            if (this.checkbutton != null)
            {
                this.checkbutton.Show();
            }
            if (button == null && checkbutton == null)
            {
                Console.WriteLine("Не является кнопкой ");
            }

            Console.WriteLine("Координаты кнопки: {0},{1}", pointX, pointY);

            Console.WriteLine("Ширина кнопки: {0}", width);
            Console.WriteLine("Высота кнопки: {0}", height);
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + superButton);
        }

        public override string ToString()
        {
            return $"pointX{pointX} \t pointY{pointY} \t width{width} \t  height{height}";
        }










        public void Input()
        {
            throw new NotImplementedException();
        }
    }
}
