using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentEksempel
{
    class ConcreteComponentName : Component
    {
        private string constructorPara;

        public ConcreteComponentName(string name)
        {
            constructorPara = name;
        }

        public override void DisplayComponent()
        {
            Console.WriteLine("The person got a name component.");
        }
        public override void DisplayComponentInfo()
        {
            Console.WriteLine(constructorPara);
        }
    }
}
