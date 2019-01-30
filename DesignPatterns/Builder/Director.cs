using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Director
    {
        public void Construct(PersonBuilder builder)
        {
            builder.BuildName();
            builder.BuildAge();
            builder.BuildGender();
        }

    }
}
