using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8.Interface
{
    internal interface IMyType
    {
        public int Age { get; set; } 

        public void MyFunc();

        public void Print()
        {
            System.Console.WriteLine("Default implemented method");
        }
    }
}
