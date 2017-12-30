using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch8_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Jimmy Lin ";
            //Trim 把前面後面空白刪掉
            Console.WriteLine("Trim: '{0}'",fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName :" + firstName);
            Console.WriteLine("LastName :" + lastName);


            var name = fullName.Split(' ');
            Console.WriteLine("FirstName :" + name[0]);
            Console.WriteLine("LastName :" + name[1]);

            Console.WriteLine(fullName.Replace("Jimmy", "Handsome"));
            Console.WriteLine(fullName.Replace("i","I"));

            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }

            var str = "25";

            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));
        }
    }
}
