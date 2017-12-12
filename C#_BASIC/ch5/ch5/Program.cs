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


        }
    }
}
