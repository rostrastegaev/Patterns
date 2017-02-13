using System;

namespace Patterns.Proxy
{
  internal class Server : IServer
  {
    public void Method1()
    {
      Console.WriteLine("Server Method 1");
    }

    public void Method2()
    {
      Console.WriteLine("Server Method 2");
    }
  }
}
