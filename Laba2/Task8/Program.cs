using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice  p = new Invoice(1,"kek","lol");

            double totalprice = p.CalculatorNds(12,13);
            Console.WriteLine("total price :"+ totalprice);
        }
    }
}
