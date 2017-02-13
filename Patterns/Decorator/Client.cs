namespace Patterns.Decorator
{
  internal class Client
  {
    public void Run()
    {
      new ItemDecorator1(new ItemDecorator2(new DefaultItem()));
    }
  }
}
