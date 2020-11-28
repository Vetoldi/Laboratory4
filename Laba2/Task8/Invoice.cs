using System;
using System.Collections.Generic;
using System.Text;

namespace Task8
{
    public class Invoice
    {
         public readonly int  account ;
         public readonly string customer;
         public readonly string provider;
        public Invoice(int z, string x, string c)
        {
            account = z;
            customer = x;
            provider = c;

        }
           private string article ;
           private int quantitу ;

        public double CalculatorNds(double quantiti,double price, double Nds_perc )
        {
            double res = quantiti*price*Nds_perc;
            return res;
        }
        public double CalculatorNds(double price, double quantiti)
        {
            double res = quantiti * price;
            return res;
        }

    }

}
    
