using Patterns.AbstractFactory;
using Patterns.Adapter;
using Patterns.FactoryMethod;
using Patterns.Proxy;
using System;

namespace Patterns
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("----------------------------- Abstract Factory -----------------------------");
      AbstractFactoryClient abstractFactoryClient = new AbstractFactoryClient(new WinFactory()); // change to MacFactory if needed
      abstractFactoryClient.Start();

      Console.WriteLine("----------------------------- Factory Method -----------------------------");
      Parent.Create().Run();
      Parent.Create().Run();

      Console.WriteLine("----------------------------- Adapter -----------------------------");
      IToAdapt toAdapt = new ToAdapt();
      IAdapter adapter = new Adapter.Adapter(toAdapt);
      adapter.NormalMethod1();
      adapter.NormalMethod2();

      Console.WriteLine("----------------------------- Proxy -----------------------------");
      IServer server = new Server();
      IServer proxyServer = new Proxy.Proxy(server);
      Client proxyClient = new Client(proxyServer);
      proxyClient.Run();

      Console.WriteLine("----------------------------- Decorator -----------------------------");
      Decorator.Client decClient = new Decorator.Client();
      decClient.Run();

      Console.ReadKey(true);
    }
  }
}
