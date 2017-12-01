using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hellocsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            byte number=2;                    //var number=2
            int count = 10;                   //var count=10
            float totalPrice = 20.95f;        //loat totalPrice = 20.95f;  
            char characater = 'A';            //var characater = 'A';
            string fireName = "Mosh";         //var fireName = "Mosh";
            bool isWorking = false;           //var isWorking = false;

            Console.WriteLine(number);
            Console.WriteLine(count);  ///cw tab兩下
            Console.WriteLine(totalPrice);
            Console.WriteLine(characater);
            Console.WriteLine(fireName);
            Console.WriteLine(isWorking);
            Console.WriteLine("{0} {1}",byte.MinValue,byte.MaxValue);
            Console.WriteLine("{0} {1}",float.MinValue,float.MaxValue);

            const float Pi = 3.14f;
            





            //ctrl + X  可以刪除該行
        }
    }
}
