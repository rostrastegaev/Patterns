using System;

namespace Patterns.Decorator
{
  internal class ItemDecorator2 : ItemDecorator
  {
    public ItemDecorator2(IItem item) : base(item)
    { }

    public override void Run()
    {
      Console.WriteLine("Item Decorator 2");
      base.Run();
    }
  }
}
