using System;

namespace Part4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ApplicationLicense a = new ApplicationLicense();
            a.AllowCommon();
            a.AllowTrial();
            a.AllowPro();


        }
    }
}
