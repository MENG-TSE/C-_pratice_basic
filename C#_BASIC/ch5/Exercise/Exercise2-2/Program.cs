﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Write a program and continuously ask the user to enter a number. The loop terminates when the user 
            /// enters “ok". Calculate the sum of all the previously entered numbers and display it on the console.
            /// </summary>
            var sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number : ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                {
                    break;
                }
                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("Sum of all numbers is: " + sum);
        }
    }
}
