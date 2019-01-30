using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Showcase_Builder
    {
        void Main()
        {
            Director director = new Director();

            PersonBuilder builder1 = new ConcreteBuilder1();
            PersonBuilder builder2 = new ConcreteBuilder2();

            director.Construct(builder1);
            director.Construct(builder2);

            Product p1 = builder1.GetResult();
            Product p2 = builder2.GetResult();

            p1.PrintProduct();
            p2.PrintProduct();

            Console.ReadKey();
        }
    }
}
