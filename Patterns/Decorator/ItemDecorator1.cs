using System;

namespace Patterns.Decorator
{
  internal class ItemDecorator1 : ItemDecorator
  {
    public ItemDecorator1(IItem item) : base(item)
    {}

    public override void Run()
    {
      Console.WriteLine("Item Decorator 1");
      base.Run();
    }
  }
}
