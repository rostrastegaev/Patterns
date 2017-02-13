namespace Patterns.FactoryMethod
{
  internal abstract class Parent
  {
    private static int counter = -1;

    public static Parent Create()
    {
      counter++;
      if (counter % 2 == 0)
      {
        return new Child1();
      }
      else
      {
        return new Child2();
      }
    }

    public abstract void Run();
  }
}
