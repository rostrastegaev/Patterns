namespace Patterns.AbstractFactory
{
    internal class AbstractFactoryClient
    {
        private IAbstractFactory _factory;

        public AbstractFactoryClient(IAbstractFactory factory)
        {
            _factory = factory;
        }

        public void Start()
        {
            _factory.CreateItem1().ShowInfo();
            _factory.CreateItem2().ShowInfo();
        }
    }
}
