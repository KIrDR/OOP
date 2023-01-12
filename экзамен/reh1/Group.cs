using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reh1
{
    public class Group : IClearnable
    {
        

        public List<Stud> Stud = new List<Stud>();
    
        public void Add(Stud s)
        {
            Stud.Add(s);
        }

        public void Clearn()
        {
            if (Stud.Count == 0)
            {
                throw new Exception();
            }
            Stud.Clear();
        }

        public void Print()
        {
            foreach(Stud h in Stud)
            {
                h.Print();
            }
        }
    }


}
