using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_3
{
    partial class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
            /// is landscape or portrait.
            /// </summary>

            Console.WriteLine("Image width: ");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Image height: ");
            var height = Convert.ToInt32(Console.ReadLine());
            
            if (width > height)
            {
                Console.WriteLine("Image is " +Program.Image.Landscape);
            }
            else
            {
                Console.WriteLine("Image is "+ Program.Image.Portrait);
            }

            
        }
    }
}
