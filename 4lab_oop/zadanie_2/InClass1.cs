using System;
using System.Collections.Generic;
using System.Text;

namespace Part2
{
    class InClass1 : BaseClass_B
    {
        public string Property1 { get; private set; } = " property1";
        public string Property2 { get; private set; } = " property2";
        public override void Method1()
        {
            base.Method2();
            Console.WriteLine("Inheritor1 class functional...");
        }
    }
}
