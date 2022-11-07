using System;

class MainClass {
  public static void Main (string[] args) 
  {
   int X = int.Parse(Console.ReadLine());
   double Y = double.Parse(Console.ReadLine());
   double cons = X/Y;

   Console.WriteLine("{0:0.000} km/l", cons);
  }
}
