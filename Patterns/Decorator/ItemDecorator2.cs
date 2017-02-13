using System;

namespace Patterns.Decorator
{
  internal class ItemDecorator2 : ItemDecorator
  {
    public ItemDecorator2(IItem item) : base(item)
    {
      Console.WriteLine("Item Decorator 2");
    }
  }
}
