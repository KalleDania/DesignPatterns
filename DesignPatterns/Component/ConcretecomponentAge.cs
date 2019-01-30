using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentEksempel
{
    class ConcretecomponentAge : Component
    {
        private string constructorPara;

        public ConcretecomponentAge(string age)
        {
            constructorPara = age;
        }
        public override void DisplayComponent()
        {
           Console.WriteLine("The person got a age component.");
        }
        public override void DisplayComponentInfo()
        {
            Console.WriteLine(constructorPara);
        }
    }
}
