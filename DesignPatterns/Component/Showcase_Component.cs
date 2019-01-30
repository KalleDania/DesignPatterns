using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentEksempel
{
    class Showcase_Component
    {
        void Main()
        {
            Person person = new Person();
            person.AddComponent(new ConcreteComponentGender("Male"));
            person.AddComponent(new ConcretecomponentAge("28"));
            person.AddComponent(new ConcreteComponentName("Kasper"));

            person.DisplayComponentInfo();
            person.DisplayComponent();
            Console.ReadKey();
            Console.WriteLine("\n");

            ConcreteComponentName lastName = new ConcreteComponentName("Nielsen");
            person.AddComponent(lastName);
            person.DisplayComponentInfo();
            Console.ReadKey();
            Console.WriteLine("\n");

            person.RemoveComponent(lastName);
            person.DisplayComponentInfo();
            Console.ReadKey();
        }
    }
}
