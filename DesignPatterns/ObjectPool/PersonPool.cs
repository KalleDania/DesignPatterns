using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektPoolExample
{
    class PersonPool
    {
        private List<Person> inactive = new List<Person>();
        private List<Person> active = new List<Person>();


        public Person CreateObject()
        {
            if (inactive.Count != 0)
            {
                Person person = inactive[0];
                active.Add(person);
                inactive.RemoveAt(0);
                return person;
            }

            else
            {
                Person newPerson = new Person();
                active.Add(newPerson);
                return newPerson;
            }
          
        }

        public void ReleaseObject(Person person)
        {
            CleanUp(person);
            inactive.Add(person);
            active.Remove(person);
        }

        public void CleanUp(Person person)
        {
            person.TempData = null;
        }
    }
}
