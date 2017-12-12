
using ch4.math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4
{
    // 37:demo:Reference Types and Value Types
    public class dog
    {
        public int Age;
    }
    //
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


            //ch4: demo:reference types and values types
            var a = 1;
            var b = 2;
            b++;
            Console.WriteLine(string.Format("a:{0},b:{1}",a,b));

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("array1[1]:{0}=array2[1]:{0}",array1[0],array2[0]));

            //37 demo:reference types and values types
            
            var num = 1;
            Increment(num);
            Console.WriteLine(num);


            var app = new dog() { Age = 20 };
            MakeOld(app);
            Console.WriteLine(app.Age);
               
            
            
        }
        //下兩個都為37 demo:reference types and values types
        public static void Increment(int number)
        {
            number += 10;
        }
        public static void MakeOld(dog dog)
        {
            dog.Age += 10;
        }
    }
}





//ctrl+tab