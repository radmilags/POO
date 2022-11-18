using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int h = int.Parse(Console.ReadLine());
    int vm = int.Parse(Console.ReadLine());
    double l;
    double d = h*vm;
    l = d/12;

    Console.WriteLine ("{0:0.000}", l);
  }
}
