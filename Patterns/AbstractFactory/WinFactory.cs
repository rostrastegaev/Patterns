namespace Patterns.AbstractFactory
{
    internal class WinFactory : IAbstractFactory
    {
        public IItem1 CreateItem1()
        {
            return new WinItem1();
        }

        public IItem2 CreateItem2()
        {
            return new WinItem2();
        }
    }
}
