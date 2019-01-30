using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeExample
{
    class PersonManager
    {
        private Dictionary<string, PersonPrototype> persons = new Dictionary<string, PersonPrototype>();

        public PersonPrototype this[string key]
        {
            get { return persons[key]; }
            set { persons.Add(key, value);}
        }
    }
}
