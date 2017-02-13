using System;

namespace Patterns.FactoryMethod
{
  internal class Child1 : Parent
  {
    public override void Run()
    {
      Console.WriteLine("Child1");
    }
  }
}
