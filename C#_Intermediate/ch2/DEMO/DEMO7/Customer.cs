using System.Collections.Generic;

namespace DEMO7
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        //ctor tab tab   is a shortcut
        public Customer(int id)
            :this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            :this(id)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
