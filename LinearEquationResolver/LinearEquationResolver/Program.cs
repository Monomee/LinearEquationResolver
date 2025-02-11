﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearEquationResolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linear Equation Resolver");
            Console.WriteLine("Given a equation as 'a * x + b = 0', please enter constants:");
            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
            {
                if (b != 0)
                {
                    Console.WriteLine("No solution!");
                }
                else
                {
                    Console.Write("The solution is all x!");
                }
            }
            else
            {
                Console.WriteLine("The solution is: " + (-b / a));
            }
            Console.ReadLine();
        }
    }
}
