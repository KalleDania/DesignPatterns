using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Product
    {
        private List<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void PrintProduct()
        {
            Console.WriteLine("Product parts:");
            foreach (string VARIABLE in parts)
            {
                Console.WriteLine(VARIABLE);
            }
        }
    }
}
