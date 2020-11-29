using System;
using System.Diagnostics;

namespace Part3
{
   
    class Program
    {

        static void Main(string[] args)
        {
            
            InherClass1 atr = new InherClass1();
            InherClass2 atr2 = new InherClass2();
            InherClass3 atr3 = new InherClass3();
            atr.Print1();
            atr2.Print2();
            atr3.Print3();
           

            Console.ReadKey();
        }
    }
}
