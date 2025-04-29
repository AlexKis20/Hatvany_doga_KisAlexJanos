using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatvany
{
    public class PowerCalculator
    {
        public double CalculatePower(double a, double b)
        {
            double eredmeny ;
            for (int i = 0; i < b; i++)
            {
                eredmeny = a * i;
            }
            return eredmeny;
        }
        static void Main(string[] args)
        {
            Console.Write("Add meg az első számot: ");
            double a=double.Parse(Console.ReadLine());
            Console.Write("Add meg az első számot: ");
            double b = double.Parse(Console.ReadLine());
            




            Console.ReadKey();
        }
    }
}
