using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Part3
{
    public class InherClass3:BaseClass
    {
        public  void Print3()
        {
            Debug.WriteLine(derived3.GetType());
            Console.WriteLine("Inheritor3  " + derived3.GetType());
        }
       public string derived3 = "Detived class 3";
    }
}
