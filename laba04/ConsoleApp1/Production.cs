using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba03
{
    internal class Production
    {
        private readonly string ProductName;
        private readonly int Id;
        private readonly string Department;

        public Production(string name, int id, string department)
        {
            ProductName = name;
            Id = id;
            Department = department;
        }
    }
}
