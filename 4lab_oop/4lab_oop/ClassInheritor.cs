using System;
using System.Collections.Generic;
using System.Text;

namespace _4lab_oop
{
    class ClassInheritor : BaseClass
    {
        public override void Method(int a, double b, string c)
        {
            //можно в методе наследника использовать функционал базового класса base.Method() при необходимости
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(a.GetType());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(b.GetType());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(c.GetType());
        }
    }
}
