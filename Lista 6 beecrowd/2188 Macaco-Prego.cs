using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int n = int.Parse(Console.ReadLine());
    int k = 1;
    while(n != 0)
    {
       bool ok = true;
       string[] s = Console.ReadLine().Split(' ');
       int x1 = int.Parse(s[0]);
       int y1 = int.Parse(s[1]);
       int x2 = int.Parse(s[2]);
       int y2 = int.Parse(s[3]);
       for (int i = 2; i <= n; i++) 
      {
        string[] r = Console.ReadLine().Split(' ');
        int x3 = int.Parse(r[0]);
        int y3 = int.Parse(r[1]);
        int x4 = int.Parse(r[2]);
        int y4 = int.Parse(r[3]);
        //int x5 = (x1 > x3 ? x1 : x3);
        int x5 = Math.Max(x1, x3);
        int y5 = Math.Min(y1, y3);
        int x6 = Math.Min(x2, x4);
        int y6 = Math.Max(y2, y4);
        if (x5 > x2 || y5 < y2 || x6 < x1 || y6 > y1)
        ok = false;
        x1 = x5; y1 = y5; x2 = x6; y2 = y6;
      }
      Console.WriteLine($"Teste {k}"); k++;
      if (ok) Console.WriteLine($"{x1} {y1} {x2} {y2}");
      else Console.WriteLine("nenhum");
      Console.WriteLine();
      n = int.Parse(Console.ReadLine()); 
    }
  }
}
