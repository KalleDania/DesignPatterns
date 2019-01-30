using System;

namespace StrategyPattern
{
    class Showcase_Strategy
    {
        void Main()
        {
            Context context;
            // Kører alle strategierne, deres funtkionalitet er i deres ConcreteStratregy
            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();

            Console.ReadKey();
        }
    }
}
