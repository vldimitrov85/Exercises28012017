using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementVariable
{
    class IncrementVariable
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (num > 255)
            {
                int var = num / 256;
                int var2 = Math.Abs(var * 256 - Math.Abs(num));
                Console.WriteLine(var2);
                Console.WriteLine("Overflowed {0} times", var);

            }
            else
            {
                Console.WriteLine(num);
            }
        }
    }
}
