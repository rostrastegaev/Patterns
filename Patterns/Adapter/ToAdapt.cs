using System;

namespace Patterns.Adapter
{
  internal class ToAdapt : IToAdapt
  {
    public void NotNormalMethod1(object configuration)
    {
      Console.WriteLine(configuration.ToString());
    }

    public void NotNormalMethod2(object configuration)
    {
      Console.WriteLine(configuration.ToString());
    }
  }
}
