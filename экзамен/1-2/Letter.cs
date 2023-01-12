using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2
{
    public  class Letter : IGetIt
    {
        public string Subject { get; set; }
        public string Text { get; set; }

        public Address addressTo;
        public Address addressFrom;
        public string Signature; 

        public Letter(string Subject, string text , Address addressTo, Address addresFrom, string Signature )
        {
            this.Subject = Subject;
            this.Text = text;
            this.addressTo = addressTo;
            this.addressFrom = addresFrom;
            this.Signature = Signature;
        }

        public override bool Equals(object obj)
        {
            if (obj is Letter)
            {
                Letter n = (Letter)obj;
                if (this.Signature == n.Signature && this.Text == n.Text)
                    return true;
                else
                    return false;
            }
            return false;
        }

        public void Read()
        {
            Console.WriteLine(Subject);
            Console.WriteLine(Text);
            Console.WriteLine(addressTo.ФИО + addressTo.email);
            Console.WriteLine(addressFrom.ФИО + addressFrom.email);
            Console.WriteLine(Signature);
        }

        public void Print()
        {
            var stream = new StreamWriter(@"G:\Программы малышей\ЛабораторныеРаботы\OOP\экзамен\1-2\bit.txt", true  );

            stream.WriteLine(Subject);
            stream.WriteLine(Text);
            stream.WriteLine(addressTo.ФИО + addressTo.email);
            stream.WriteLine(addressFrom.ФИО + addressFrom.email);
            stream.WriteLine(Signature);
            stream.Close();
        }
    }
}
