namespace Patterns.Adapter
{
  internal class Adapter : IAdapter
  {
    private IToAdapt _toAdapt;

    public Adapter(IToAdapt toAdapt)
    {
      _toAdapt = toAdapt;
    }

    public void NormalMethod1()
    {
      _toAdapt.NotNormalMethod1("Adapter 1");
    }

    public void NormalMethod2()
    {
      _toAdapt.NotNormalMethod2("Adapter 2");
    }
  }
}
