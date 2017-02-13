using System;

namespace Patterns.Decorator
{
  internal class ItemDecorator1 : ItemDecorator
  {
    public ItemDecorator1(IItem item) : base(item)
    {
      Console.WriteLine("Item Decorator 1");
    }
  }
}
