using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableinHexadecimalFormat
{
    class VariableinHexadecimalFormat
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine();
            var intput = Convert.ToInt32(num, 16);
            Console.WriteLine(intput);
        }
    }
}
