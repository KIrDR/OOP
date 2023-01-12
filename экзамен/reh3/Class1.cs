using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reh3
{
    interface IMovable
    {
        public const int minSpeed = 0;     // минимальная скорость
        private static int maxSpeed = 60;   // максимальная скорость
        public void Move();
        protected internal string Name { get; set; }    // название
        public delegate void MoveHandler(string message);  // определение делегата для события
        public event MoveHandler MoveEvent;    // событие движения
    }
    class OOP : IMovable
    {

        string IMovable.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event IMovable.MoveHandler MoveEvent;

        event IMovable.MoveHandler IMovable.MoveEvent
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        void IMovable.Move()
        {
            throw new NotImplementedException();
        }
    }
}
