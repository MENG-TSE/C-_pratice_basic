using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
            /// If the user guesses the number, display “You won". Otherwise, display “You lost".
            /// </summary>
            var input = new Random().Next(1, 10);
            Console.WriteLine("Answer is " + input);

            var guess = Convert.ToInt32(Console.ReadLine());

            if(guess == input)
            {
                Console.WriteLine("You Won");
                return;
            }
            else
            {
                Console.WriteLine("You lost");
            }

        }
    }
}
