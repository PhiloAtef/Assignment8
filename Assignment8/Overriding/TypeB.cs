﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8.Overriding
{
    public class TypeB : TypeA
    {
        public int B { get; set; }

        public TypeB(int _A, int _B) : base(_A)
        {
                B = _B;
        }

    }
}
