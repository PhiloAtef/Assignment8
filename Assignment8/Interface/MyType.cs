using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8.Interface
{
    internal class MyType : IMyType
    {
        public int Age { get; set; }

        public void MyFunc()
        {
            System.Console.WriteLine("Hello Route!");
        }
    }
}
