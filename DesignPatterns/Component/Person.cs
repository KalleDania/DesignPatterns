using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentEksempel
{
    class Person
    {
        private List<Component> myComponents = new List<Component>(); 

        public Person()
        {
            
        }

        public void AddComponent(Component component)
        {
            myComponents.Add(component);
        }

        //public Component GetComponent(Component component)
        //{
        //    return component;
        //}

        public void RemoveComponent(Component component)
        {
            myComponents.Remove(component);
        }

        public void DisplayComponent()
        {
            foreach (var VARIABLE in myComponents)
            {
                VARIABLE.DisplayComponent();
            }
        }

        public void DisplayComponentInfo()
        {
            foreach (var VARIABLE in myComponents)
            {
                VARIABLE.DisplayComponentInfo();
            }
        }
    }
}
