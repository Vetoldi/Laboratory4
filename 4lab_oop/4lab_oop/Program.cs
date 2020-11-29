using System;

namespace _4lab_oop
{
    

    

    class Program
    {
        static void Main(string[] args)
        {
            BaseClass a = new ClassInheritor();
            a.Method(1, 2.3, "3");
            BaseClass b = new BaseClass();
            a = b;
            a.Method(1 ,2.3,"3");
        }
    }
}
