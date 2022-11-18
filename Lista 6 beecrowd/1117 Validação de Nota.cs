using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.Clear();
    double a = 0; 
    double b = 0;
    double x = 0;

    do
    {
      a = double.Parse(Console.ReadLine());
      if(a < 0 || a > 10) Console.WriteLine("nota invalida");
      else x += a;
    } while(a < 0 || a > 10);
    do
    {
      a = double.Parse(Console.ReadLine());
      if(a < 0 || a > 10) Console.WriteLine("nota invalida");
      else x += a;
    } while(a < 0 || a > 10);

    x /= 2.0;
    Console.WriteLine($"media = {x}");
  }
}
/*-3.5
3.5
11.0
10.0*/
/*nota invalida
nota invalida
media = 6.75*/
