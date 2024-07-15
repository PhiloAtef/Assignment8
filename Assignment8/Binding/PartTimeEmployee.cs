using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8.Binding
{
    internal class PartTimeEmployee : Employee
    {
        public decimal HourRate { get; set; }

        public new void MyFunc01()
        {
            Console.WriteLine("I am PartTimeEmployee");
        }

        public override void MyFunc02()
        {
            Console.WriteLine($"ID = {ID}, Name = {Name}, Age = {Age}, HourRate = {HourRate}");
        }
    }
}
