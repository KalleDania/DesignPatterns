using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample
{
    class ConcreteSubjetIBM : Stock
    {
        // Constructor
        public ConcreteSubjetIBM(string symbol, double price) : base(symbol, price)
        {
        }
    }
}
