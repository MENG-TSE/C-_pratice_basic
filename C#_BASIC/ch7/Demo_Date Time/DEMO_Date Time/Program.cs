using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2017,08,10);
            var now = DateTime.Now;
            var today = DateTime.Today;
            

            Console.WriteLine("Hours :" + now.Hour);
            Console.WriteLine("Minutes : " + now.Minute);
            Console.WriteLine("Month : " + now.Month);

            var tomrrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));



            // Google c# datetime format specifer
        }
    }
}
