using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample
{
    class Showcase_Observer
    {
        void Main()
        {
            // Create IBM stock and attach investors
            ConcreteSubjetIBM ibm = new ConcreteSubjetIBM("IBM", 120.00);
            ibm.Attach(new Investor("Sorros"));
            ibm.Attach(new Investor("Berkshire"));

            // Fluctuating prices will notify investors
            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;

            // Wait for user
            Console.ReadKey();
        }
    }
}
