﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            var operand1 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            var operand2 = int.Parse(Console.ReadLine());
            switch (operation)
            {
                case "+": Console.WriteLine("{0} + {1} = {2}", operand1, operand2, operand1 + operand2); break;
                case "-": Console.WriteLine("{0} - {1} = {2}", operand1, operand2, operand1-operand2); break;
                case "*": Console.WriteLine("{0} * {1} = {2}", operand1, operand2, operand1 * operand2); break;
                case "/": Console.WriteLine("{0} / {1} = {2}", operand1, operand2, operand1 / operand2); break;
            }
        }
    }
}
