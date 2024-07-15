using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8.Overriding
{
    public class TypeA
    {
        public int A { get; set; }

        public TypeA(int _a)
        { 
            A = _a;
        }

        public void MyFunc01()
        {
            Console.WriteLine("I am base");
        }

        public virtual void MyFunc02()
        {
            Console.WriteLine($"TypeA = {A}");
        }
    }
}
