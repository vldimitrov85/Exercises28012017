using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelingAtLightSpeed
{
    class TravelingAtLightSpeed
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var lightYear = 9450000000000;
            var speedOfLight = 300000;
            var seconds = (lightYear / speedOfLight) * input;
            var minutes = seconds / 60;
            var hours = minutes / 60;
            var days = hours / 24;
            var weeks = days / 7;

            Console.WriteLine(weeks + " weeks");
            Console.WriteLine(days + " days");
            Console.WriteLine(hours + " hours");
            Console.WriteLine(minutes + " minutes");
            Console.WriteLine(seconds + " seconds");
        }
    }
}
