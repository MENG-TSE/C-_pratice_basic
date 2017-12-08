using System;

namespace ch4
{
    public class Person
    {
        public string FirstName;
        public string LastName;

         public void Introduce()
          {
            Console.WriteLine("My name is" + FirstName +" " + LastName);
          }
    }
}
