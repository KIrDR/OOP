using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2
{
    public  class Address
    {
        public string ФИО {  get; set; }
        public string email { get; set;  }

        public Address (string фИО, string email)
        {
            ФИО = фИО;
            this.email = email;
        }
    }
}
