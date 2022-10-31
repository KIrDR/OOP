using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace laba05
{
    public class UI
    {
        private List<AbstaractFigure> _list;

        public UI()
        {
            _list = new List<AbstaractFigure>();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public List<AbstaractFigure> list
        {
            get => _list;
            set
            {
                if (value is List<AbstaractFigure>)
                {
                    _list = value;
                }
            }
        }

        public void Add(object value)
        {
            if (value is AbstaractFigure being)
            {
                _list.Add(being);
            }
        }

        public void Remove(object value)
        {
            if (value is AbstaractFigure being)
            {
                _list.Remove(being);
            }
        }
        
    }
}
