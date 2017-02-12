using System;

namespace Patterns.AbstractFactory
{
    internal class WinItem1 : IItem1
    {
        public void ShowInfo()
        {
            Console.WriteLine("WinItem1");
        }
    }
}
