using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentEksempel
{
    class ConcreteComponentGender : Component
    {
        private string constructorPara;

        public ConcreteComponentGender(string gender)
        {
            constructorPara = gender;
        }
        public override void DisplayComponent()
        {
            Console.WriteLine("The person got a gender component.");
        }
        public override void DisplayComponentInfo()
        {
            Console.WriteLine(constructorPara);
        }
    }
}
