using Laba03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 
{
    public interface IGenericInterface <T> 
    {

        public void Show();

        public void Delete(int index, int quantity);

        public void Add(T e);


    }
}
