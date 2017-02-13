namespace Patterns.Decorator
{
  internal abstract class ItemDecorator : IItem
  {
    private IItem _item;

    protected ItemDecorator(IItem item)
    {
      _item = item;
    }
  }
}
