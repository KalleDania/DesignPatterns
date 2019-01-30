using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample
{
    class Bank
    {
        public bool HasEnoughMoney(Customer customer, int amount)
        {
            Console.WriteLine("Check bank " + customer.Name);
            return true;
        }
    }
}
