using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeExample
{
    class Showcase_Prototype
    {
        void Main()
        {
            PersonManager personManager = new PersonManager();

            personManager["Kasper"] = new Person("Male", "Kasper","29");
            personManager["Mads"] = new Person("Male", "Mads", "25");
            personManager["Far"] = new Person("Male", "Henrik", "60");
            personManager["Mor"] = new Person("FeMale", "Liane", "54");

            Person clonedPerson = personManager["Kasper"].Clone() as Person;

            Console.ReadKey();
        }
    }
}
