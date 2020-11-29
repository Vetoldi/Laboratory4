using System;
using System.Collections.Generic;
using System.Text;

namespace _4lab_oop
{
    class BaseClass
    {
        public virtual void Method(int a, double b, string c)
        {
            Console.ResetColor();
            Console.WriteLine($"{a}, {b}, {c}");
        }
    }
}
