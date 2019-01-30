using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    abstract class PersonBuilder
    {
        public abstract void BuildName();
        public abstract void BuildAge();
        public abstract void BuildGender();
        public abstract Product GetResult();
    }
}
