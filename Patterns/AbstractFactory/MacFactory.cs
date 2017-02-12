namespace Patterns.AbstractFactory
{
    internal class MacFactory : IAbstractFactory
    {
        public IItem1 CreateItem1()
        {
            return new MacItem1();
        }

        public IItem2 CreateItem2()
        {
            return new MacItem2();
        }
    }
}
