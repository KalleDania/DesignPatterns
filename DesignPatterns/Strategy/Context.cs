namespace StrategyPattern
{
    class Context
    {
        private Strategy strategy;

        public Context(Strategy newStrategy)
        {
            this.strategy = newStrategy;
        }

        public void ContextInterface()
        {
            strategy.AlgorithmInterface();
        }
    }
}
