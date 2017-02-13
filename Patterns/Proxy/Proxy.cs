using System;

namespace Patterns.Proxy
{
  internal class Proxy : IServer
  {
    private IServer _server;

    public Proxy(IServer server)
    {
      _server = server;
    }

    public void Method1()
    {
      Console.WriteLine("Proxy addition 1");
      _server.Method1();
    }

    public void Method2()
    {
      Console.WriteLine("Proxy addition 2");
      _server.Method2();
    }
  }
}
