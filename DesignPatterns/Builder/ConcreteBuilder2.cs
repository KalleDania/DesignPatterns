using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class ConcreteBuilder2 : PersonBuilder
    {
        private Product product = new Product();

        public override void BuildName()
        {
            product.Add("Mads Nielsen");
        }

        public override void BuildAge()
        {
            product.Add("25");
        }

        public override void BuildGender()
        {
            product.Add("Male");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
