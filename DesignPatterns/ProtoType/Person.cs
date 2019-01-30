using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeExample
{
    class Person : PersonPrototype
    {
        private string gender;
        private string name;
        private string age;

        public Person(string newGender, string newName, string newAge)
        {
            this.gender = newGender;
            this.name = newName;
            this.age = newAge;
        }

        public override PersonPrototype Clone()
        {
            Console.WriteLine("Cloning a person: {0,3},{1,3},{2,3}", gender, name, age);

            return this.MemberwiseClone() as PersonPrototype;
        }
    }
}
