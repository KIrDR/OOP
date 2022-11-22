using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba03
{
    public class Circle : AbstaractFigure , IManagement
    {
        public float radius;
        public Button? button;
        public Radiobutton? radoibutton;

        Radiobutton superButton = new Radiobutton();
        public Circle(float pointX, float pointY, float radius, ElemOfManage button)
        {

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
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t" + superButton);

        }
























        public void Input()  
        {

            

            
        }
    }
}
