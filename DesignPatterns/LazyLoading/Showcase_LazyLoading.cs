using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingExample
{
    class Showcase_LazyLoading
    {
        void Main()
        {
            // Create Lazy.
            Lazy<Person> lazyperson = new Lazy<Person>();

            // Show that IsValueCreated is false.
            Console.WriteLine("IsValueCreated = {0}", lazyperson.IsValueCreated);

            // Get the Value.
            // ... This executes Test().
            Person person = lazyperson.Value;

            // Show the IsValueCreated is true.
            Console.WriteLine("IsValueCreated = {0}", lazyperson.IsValueCreated);

            // The object can be used.
            Console.WriteLine("Length = {0}", person.Length);

            Console.ReadKey();
        }
    }
}
