using System;

namespace Patterns.Decorator
{
  internal class DefaultItem : IItem
  {
    public void Run()
    {
      Console.WriteLine("Default Item");
    }
  }
}
