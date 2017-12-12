using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hellocsharp
{
    class Test1
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

            ///Demo:type Conversion
            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            int c = 1;   //max 255
            byte d = (byte)c;
            Console.WriteLine(d);


            var numbers = "1234";
            int e = Convert.ToInt32(numbers);
            Console.WriteLine(e);



            try
            {
                var abc = "1234";
                int abcd = Convert.ToByte(abc);
                Console.WriteLine(abcd);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte");
            }



            try
            {
                string str = "true";
                bool m = Convert.ToBoolean(str);
                Console.WriteLine(m);
            }
            catch (Exception)
            {
                Console.WriteLine("The string could not be converted to boolean");
            }
            //參考資料 GOOGLE:C#build-in types
        }
    }
}
