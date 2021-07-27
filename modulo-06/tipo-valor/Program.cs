using System;

namespace tipos
{
  class Program
  {
    static void Main(string[] args)
    {
      Point p; // Strct não necessita de iniciar com um new.
      p.X = 10;
      p.Y = 5;

      Console.WriteLine(p);

      p = new Point();
      Console.WriteLine(p);
    }
  }
}
