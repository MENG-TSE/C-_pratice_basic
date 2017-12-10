using ch4.math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4
{
    class Program
    {
        static void Main(string[] args)
        {
            var jimmy = new Person();
            jimmy.FirstName = " MENG ";
            jimmy.LastName = "LIN ";
            jimmy.Introduce();

            var Calulater = new Caculater();
            var result = Calulater.Add(1, 2);
            Console.WriteLine(result);

            ///30 demo:Arrays
            var number =new int[3];
            number[0] = 1;

            Console.WriteLine(number[0]);
            Console.WriteLine(number[1]);
            Console.WriteLine(number[2]);


            ///Demo Strings
            var firstName = "MOSH";
            var lastName = "howard";

            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("my name is {0} {1}", firstName, lastName);
            var names = new string[3] { "A", "B", "C" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            var text = @"Hi John
Look into the following paths
c:\folder1\folders2
c:\QQ\QQ";
            var aloha = @"Jimmy is so handsome";
            Console.WriteLine(text);
            Console.WriteLine(aloha);
        }
    }
}





//ctrl+tab