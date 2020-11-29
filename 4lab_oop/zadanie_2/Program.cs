using System;

namespace Part2
{
    

    class Program
    {
        static void Main(string[] args)
        {
            InClass1 a = new InClass1();

            InClass2 b = new InClass2();

            InClass3 c = new InClass3();

            Console.WriteLine(a.Property1 + "\n" + a.Property2 + "\n--------------------------");

            Console.WriteLine(b.Property1 + "\n" + b.Property2 + "\n--------------------------");

            Console.WriteLine(c.Property1 + "\n" + c.Property2 + "\n--------------------------");
        }
    }
}
