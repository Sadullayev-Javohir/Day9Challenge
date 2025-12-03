abstract class University
{
  public void Teach()
  {
    Console.WriteLine("Teacher teach students");
  }

  public abstract void Examination();
}

class Pdp : University
{
  public override void Examination()
  {
    Console.WriteLine("Examination begin");
  }
}

class Program
{
  static void Main()
  {
        var pdp = new Pdp();
        pdp.Examination();
        pdp.Teach();
  }
}
