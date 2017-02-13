using System;

namespace Patterns.Decorator
{
  internal class DefaultItem : IItem
  {
    public DefaultItem()
    {
      Console.WriteLine("Default Item");
    }
  }
}
