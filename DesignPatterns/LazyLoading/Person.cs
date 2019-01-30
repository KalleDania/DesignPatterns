using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingExample
{
    class Person
    {
        int[] array;

        public Person()
        {
            Console.WriteLine("This is a person.");
            array = new int[10];
        }

        public int Length
        {
            get
            {
                return array.Length;
                
            }
        }
    }
}
