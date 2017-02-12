using Patterns.AbstractFactory;
using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactoryClient abstractFactoryClient = new AbstractFactoryClient(new WinFactory()); // change to MacFactory if needed
            abstractFactoryClient.Start();
            Console.ReadKey(true);
        }
    }
}
