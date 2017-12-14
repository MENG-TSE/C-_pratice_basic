using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_part2
{
    class Program
    {
        static void Main(string[] args)
        {

            //var random = new Random();
            //for(var i = 1; i < 10; i++)
            //Console.WriteLine((char)('a' + random.Next(0,26)));
            //Console.WriteLine();


            var random = new Random();
            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            for (var i = 0; i < 10; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
                var password = new string(buffer);

                Console.WriteLine(password);
            }
        }



    }
}
