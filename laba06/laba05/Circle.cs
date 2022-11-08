using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba05
{
    public class Circle : AbstaractFigure, IManagement
    {
        public float radius;
        public Color color = new Color();
        public Button? button;
        public Radiobutton? radoibutton;



        public Circle(float pointX, float pointY, float radius, ElemOfManage button, int colorType)
        {

            if (pointX < 0)
            {
                throw new InvalidPositionException("invalid position", (int)pointX);
            }

            if (pointY < 0)
            {
                throw new InvalidPositionException("invalid position", (int)pointY);
            }
            this.pointX = pointX;
            this.pointY = pointY;
            if (radius < 0 || radius > 100)
            {
                throw new InvalidTypeException("invalid type", (int)radius);
            }

            this.radius = radius;
            Button niceButton1 = button as Button;
            this.button = niceButton1;
            if (this.button == null)
            {
                Radiobutton niceButton2 = button as Radiobutton;
                this.radoibutton = niceButton2;
                if (this.button == null)
                {
                    Checktbox radioButton1 = button as Checktbox;
                    if (radioButton1 != null)
                    {
                        Console.WriteLine("Прямоугольник не может быть Checktbox");
                    }
                }
            }
            if (colorType < -1 || colorType > 4)
            {
                throw new InvalidTypeException("invalid type", colorType);
            }
            if (colorType == 1)
            {
                color.red = 255;
                color.green = 0;
                color.blue = 0;
                color.alpha = 1;
            }
            if (colorType == 2)
            {
                color.red = 0;
                color.green = 255;
                color.blue = 0;
                color.alpha = 1;
            }
            if (colorType == 3)
            {
                color.red = 0;
                color.green = 0;
                color.blue = 255;
                color.alpha = 1;
            }
            if (colorType == 16581375)
            {
                color.red = 255;
                color.green = 255;
                color.blue = 255;
                color.alpha = 1;
            }
            if (colorType == 0)
            {
                color.red = 0;
                color.green = 0;
                color.blue = 0;
                color.alpha = 1;
            }
        }

        public Circle(float pointX, float pointY, float radius, ElemOfManage button, byte alpha, byte red, byte green, byte blue)
        {
            color.alpha = alpha;
            color.red = red;
            color.green = green;
            color.blue = blue;

            if (radius < 0 || radius > 100)
            {
                throw new InvalidTypeException("invalid type", (int)radius);
            }

            this.pointX = pointX;
            this.pointY = pointY;
            this.radius = radius;
            Button niceButton1 = button as Button;
            this.button = niceButton1;
            if (this.button == null)
            {
                Radiobutton niceButton2 = button as Radiobutton;
                this.radoibutton = niceButton2;
                if (this.button == null)
                {
                    Checktbox radioButton1 = button as Checktbox;
                    if (radioButton1 != null)
                    {
                        Console.WriteLine("Прямоугольник не может быть Checktbox");
                    }
                }
            }
        }

        public Circle(float pointX, float pointY, float radius, ElemOfManage button)
        {

            if (radius < 0 || radius > 100)
            {
                throw new InvalidTypeException("invalid type", (int)radius);
            }

            this.pointX = pointX;
            this.pointY = pointY;
            this.radius = radius;
            Button niceButton1 = button as Button;
            this.button = niceButton1;
            if (this.button == null)
            {
                Radiobutton niceButton2 = button as Radiobutton;
                this.radoibutton = niceButton2;
                if (this.button == null)
                {
                    Checktbox radioButton1 = button as Checktbox;
                    if (radioButton1 != null)
                    {
                        Console.WriteLine("Прямоугольник не может быть Checktbox");
                    }
                }
            }
        }


        public override  string  ToString()
        {
            return $"pointX{pointX} \t pointY{pointY} \t Radius{radius} \t ";
        }

        void IManagement.Show() 
        {

            Console.WriteLine("Координаты кнопки: {0},{1}", pointX, pointY) ;

            Console.WriteLine("Радиус кнопки: {0}", radius);

        }

        public override void Show()
        {
            Console.WriteLine("\n\n\n");

            if (this.button != null)
            {
                this.button.Show();
            }
            if (this.radoibutton != null)
            {
                this.radoibutton.Show();
            }
            if (button == null && radoibutton == null)
            {
                Console.WriteLine("Не является кнопкой ");
            }

            Console.WriteLine("Координаты кнопки: {0},{1}", pointX, pointY);

            Console.WriteLine("Радиус кнопки: {0}", radius);

            Console.WriteLine($"цвета элемента красный {color.red}  зеленый {color.green}  синий {color.blue} прозрачность {color.alpha}");
        }
























        public void Input()  
        {

            

            
        }
    }
}
