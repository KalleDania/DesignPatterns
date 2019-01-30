using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektPoolExample
{
    class Person
    {
        public string TempData { get; set; }

        DateTime createAt = DateTime.Now;

        public DateTime CreateAT
        {
            get
            {
                return createAt;
            }
        }

    }
}
