using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.Clear();
    int a = 0, b = 1, c = 0;
    int n = int.Parse(Console.ReadLine());
    for(int i = 1; i < n; i++)
    {
      Console.Write($"{a} ");
      c = a+b; a = b; b = c;
    }
    Console.WriteLine(a);
  }
}
