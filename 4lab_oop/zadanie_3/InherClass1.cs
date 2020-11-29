using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Part3
{
    public class InherClass1:BaseClass
    {
        public string derived1 = "Derived class1";
        
        public  void Print1()
        {
            Debug.WriteLine(derived1.GetType());
            Console.WriteLine("Inheritor1  " + derived1.GetType());
        }
    }
}
