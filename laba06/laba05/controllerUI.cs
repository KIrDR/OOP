using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba05
{
    public class ControllerUI
    {
        public void Leng(UI _list)
        {
            Console.WriteLine($"Всего зарегистрированно {_list.list.Count()} элементов ");
        }


        public void AllSquare(UI _list)
        {
            double square = 0;
            foreach (var being in _list.list)
            {
                switch (being)
                {
                    case (Circle):
                        square += ((Circle)being).radius * ((Circle)being).radius * Math.PI;
                        break;

                    case (Rectangle):
                        square += ((Rectangle)being).width * ((Rectangle)being).height;
                        break;
                }
            }

            Console.WriteLine(Math.Round(square, 3));
        }

        public void Print(UI _list)
        {
            foreach (var being in _list.list)
            {
                switch (being)
                {
                    case Circle:
                        if (((Circle)being).button != null)
                        {
                            Console.WriteLine($"Круглая кнопка (Button) площадью {Math.Round(((Circle)being).radius * ((Circle)being).radius * Math.PI, 2)}" +
                                $", и расположена по координатом X:{((Circle)being).pointX}\t Y:{((Circle)being).pointY}");
                        }
                        if (((Circle)being).radoibutton != null)
                        {
                            Console.WriteLine($"Круглая радио-кнопка (Radoibutton) площадью {Math.Round(((Circle)being).radius * ((Circle)being).radius * Math.PI, 2)}" +
                                $", и расположена по координатом X:{((Circle)being).pointX}\t Y:{((Circle)being).pointY}");
                        }
                        break;
                    case Rectangle:
                        if (((Rectangle)being).button != null)
                        {
                            Console.WriteLine($"Прямоугольная кнопка (Button) площадью {((Rectangle)being).width * ((Rectangle)being).height}" +
                                $", и расположена по координатом X:{((Rectangle)being).pointX}\t Y:{((Rectangle)being).pointY}");
                        }
                        if (((Rectangle)being).checkbutton != null)
                        {
                            Console.WriteLine($"Круглая радио-кнопка (Radoibutton) площадью {((Rectangle)being).width * ((Rectangle)being).height}" +
                                $", и расположена по координатом X:{((Rectangle)being).pointX}\t Y:{((Rectangle)being).pointY}");
                        }
                        break;
                    default:
                        Console.WriteLine($"error");
                        break;
                }
            }
        }
    }
}
