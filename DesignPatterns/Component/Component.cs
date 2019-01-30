using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentEksempel
{
    abstract class Component
    {

        public Component()
        {
            
        }

        public abstract void DisplayComponent();
        public abstract void DisplayComponentInfo();
    }
}
