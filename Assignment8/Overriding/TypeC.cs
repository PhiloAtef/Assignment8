using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8.Overriding
{
    class TypeC: TypeB
    {
        public int C { get; set; }

        public TypeC(int _a, int _b, int _c) : base(_a, _b)
        {
            C = _c;
        }

        public new void MyFunc01()
        {
            System.Console.WriteLine("I am grand child");
        }

        public override void MyFunc02()
        {
            System.Console.WriteLine($"C = {C}");
        }
    }

    class TypeD : TypeC
    {
        public int D { get; set; }

        public TypeD(int _a, int _b, int _c, int _d) : base(_a, _b, _c)
        {
            D = _d;
        }

        public new void MyFunc01()
        {
            System.Console.WriteLine("I am grand grand child");
        }

        public new virtual void MyFunc02()
        {
            System.Console.WriteLine($"D = {D}");
        }
    }

    class TypeE : TypeD
    {
        public int E { get; set; }

        public TypeE(int _a, int _b, int _c, int _d, int _e) : base(_a, _b, _c, _d)
        {
            E = _e;
        }

        public override void MyFunc02()
        {
            System.Console.WriteLine($"E = {E}");
        }
    }
}
