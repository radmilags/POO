using System;

class MainClass {
  public static void Main (string[] args) 
  {
   double T,B;
   
   string N = Console.ReadLine();
   double S = Convert.ToDouble(Console.ReadLine());
   double V = Convert.ToDouble(Console.ReadLine());
   
   B = V/100*15;
   T = S + B;
   Console.WriteLine("TOTAL = R$ {0:0.00}",T);
   
  }
}
