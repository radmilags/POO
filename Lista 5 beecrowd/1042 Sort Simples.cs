using System;

class MainClass {
  public static void Main (string[] args) 
  {
    string[] s = Console.ReadLine().Split(' ');// 7 21 -14
    int a = int.Parse(s[0]);
    int b = int.Parse(s[1]);
    int c = int.Parse(s[2]);

    /*int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());*/

    int x = a;
    int y = b;
    int z = c;

    int m;
    if(a > b)
    {
      m = a;
      a = b;
      b = m;

    }
     if(a > c)
    {
      m = a;
      a = c;
      c = m;
      
    }
     if(b > c)
    {
      m = b;
      b = c;
      c = m;

    }

    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
    Console.WriteLine();
    Console.WriteLine(x);
    Console.WriteLine(y);
    Console.WriteLine(z);
  }
}
