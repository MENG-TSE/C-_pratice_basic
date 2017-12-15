using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Write a program which takes two numbers from the console and displays the maximum of the two.
            /// </summary>
            Console.WriteLine("Enter a number");
            var number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            var number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 > number2)
            {
                Console.WriteLine("Max is " + number1);
            }
            else if(number1 == number2){
                Console.WriteLine("two numbers are euqal");
            }
            else
            {
                Console.WriteLine("Max is" + number2);
            }
        }
    }
}
