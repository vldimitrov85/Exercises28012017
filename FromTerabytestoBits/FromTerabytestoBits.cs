using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromTerabytestoBits
{
    class FromTerabytestoBits
    {
        static void Main(string[] args)
        {
            var inputValue = decimal.Parse(Console.ReadLine());
            decimal teraByte = (decimal)1024 * 1024 * 1024 * 1024 * 8;
            Console.WriteLine(Math.Round(inputValue*teraByte));
        }
    }
}
