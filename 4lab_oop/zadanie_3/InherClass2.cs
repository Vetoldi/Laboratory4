using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Part3
{
    public class InherClass2:BaseClass
    {
        public  void Print2()
        {
            Debug.WriteLine(derived2.GetType());
            Console.WriteLine("Inheritor2  " + derived2.GetType());
        }
        public string derived2 = "Derived class2";
    }
}
