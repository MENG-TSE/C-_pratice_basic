using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch6
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new[] { 3, 7, 9, 2, 14, 6 };

            //Length
            Console.WriteLine("Length : " + number.Length);


            //IndexOf()
            var index = Array.IndexOf(number, 9);
            Console.WriteLine("Index of 9 is " + index);


            //Clear()  
            Array.Clear(number, 0, 2);
            Console.WriteLine("Effect of Clear()");
            foreach (var n in number)
            {
                Console.WriteLine(n);
            }


            //Copy()
            int[] another = new int[3];
            Array.Copy(number, another, 3);
            Console.WriteLine("Effect of Copy()");
            foreach(var n in another)
            {
                Console.WriteLine(n);
            }


            //Sort()
            Array.Sort(number);
            Console.WriteLine("Effect of Sort()");
            foreach(var i in number)
            {
                Console.WriteLine(i);
            }


            //Reverse
            Array.Reverse(number);
            Console.WriteLine("Effect of Reverse()");
            foreach(var i in number)
            {
                Console.WriteLine(i);
            }



        }
    }
}
