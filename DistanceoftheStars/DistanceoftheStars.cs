using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceoftheStars
{
    class DistanceoftheStars
    {
        static void Main(string[] args)
        {
            decimal lightYear = 9450000000000;
            decimal num1 = (decimal)4.22*lightYear;
            decimal num2 = 26000*lightYear;
            decimal num3 = 100000*lightYear;
            decimal num4 = 46500000000*lightYear;
                       
            Console.WriteLine(num1.ToString("e2"));
            Console.WriteLine(num2.ToString("e2"));
            Console.WriteLine(num3.ToString("e2"));
            Console.WriteLine(num4.ToString("e2"));
        }
    }
}
