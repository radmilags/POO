using System;

class MainClass {
  public static void Main (string[] args) 
  {
    double e,f,g;
    string[] p1 = Console.ReadLine().Split(' ');
    string[] p2 = Console.ReadLine().Split(' ');
    double x1 = double.Parse(p1[0]);
    double y1 = double.Parse(p1[1]);
    double x2 = double.Parse(p2[0]);
    double y2 = double.Parse(p2[1]);

    e = (x2-x1)*(x2-x1);
    f = (y2-y1)*(y2-y1);
    g = e + f;

    Console.WriteLine("{0:0.0000}",Math.Sqrt(g));
  }
}
