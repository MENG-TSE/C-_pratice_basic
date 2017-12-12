using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Gold = true;
            //float price;
            //if (Gold)
            //{
            //    price = 19.95f;
            //}
            //else
            //{
            //    price = 29.95f;
            //}
            float price = (Gold) ? 19.95f : 29.95f;

            Console.WriteLine(price);

            var season = Season.Autumn;
          //switch
            switch(season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's QQ");
                    break;
                case Season.Summer:
                case Season.Spring:
                    Console.WriteLine("It's great");
                    break;
                default:
                    Console.WriteLine("It's Winter");
                    break;
            }

            for(var i = 1; i <= 10; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }
            for(var i=10; i > 0; i--)
            {
                if(i % 2 ==0)
                {
                    Console.WriteLine(i);
                }
            }

            //foreach
            var name = " Jimmy L";

            //for(var i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}
            foreach(var character in name)
            {
                Console.WriteLine(character);
            }
            //ex2(array)
            var array = new int[] { 1, 2, 3 };
            foreach(var QQ in array)
            {
                Console.WriteLine(QQ);
            }


        }
    }
}
