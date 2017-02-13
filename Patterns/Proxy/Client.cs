namespace Patterns.Proxy
{
  internal class Client
  {
    private IServer _server;

    public Client(IServer server)
    {
      _server = server;
    }

    public void Run()
    {
      _server.Method1();
      _server.Method2();
    }
  }
}
