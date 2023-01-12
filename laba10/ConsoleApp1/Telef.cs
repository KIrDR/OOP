using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  delegate void Ring(); 
    public class Telephone
    {
        public event Ring supeRring;
        
        public void Call()
        {
            if (supeRring != null)
                supeRring();
        }

    }
}
