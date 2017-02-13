using Patterns.AbstractFactory;
using Patterns.FactoryMethod;
using System;

namespace Patterns
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("----------------------------- Abstract Factory -----------------------------");
      AbstractFactoryClient abstractFactoryClient = new AbstractFactoryClient(new WinFactory()); // change to MacFactory if needed
      abstractFactoryClient.Start();

      Console.WriteLine("----------------------------- Factory Method -----------------------------");
      Parent.Create().Run();
      Parent.Create().Run();

      Console.ReadKey(true);
    }
  }
}
