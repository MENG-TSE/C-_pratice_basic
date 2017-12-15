using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new List<int>() { 1, 2, 3, 4 };
            number.Add(1);
            number.AddRange(new int[3] { 5, 6, 7 });

            foreach(var i in number)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            Console.WriteLine("Index of 1 : " + number.IndexOf(1));
            Console.WriteLine("Last Index of 1 : " + number.LastIndexOf(1));

            Console.WriteLine("Count:" + number.Count);

            for(var i = 0; i < number.Count; i++)
            {
                if (number[i] == 1)
                {
                    number.Remove(number[i]);
                }
            }
            foreach(var i in number)
            {
                Console.WriteLine(number);
            }

            number.Clear();
            Console.WriteLine("Count:" + number.Count);
        }
    }
}
