using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo12
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1995, 8, 10));
            Console.WriteLine(person.Age);
        }
    }
}
