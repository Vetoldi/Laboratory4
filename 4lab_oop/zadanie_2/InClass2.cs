using System;
using System.Collections.Generic;
using System.Text;

namespace Part2
{
    class InClass2 : BaseClass_B
    {
        public string Property1 { get; private set; } = "property1";
        public string Property2 { get; private set; } = "property2";
        public override void Method2()
        {
            Console.WriteLine("Inher2 class functional...");
        }
    }
}
