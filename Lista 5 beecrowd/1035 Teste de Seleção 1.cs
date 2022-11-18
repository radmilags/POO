using System;

class MainClass {
  public static void Main (string[] args) 
  {
    string[] s = Console.ReadLine().Split(' ');

    int A = int.Parse(s[0]);
    int B = int.Parse(s[1]);
    int C = int.Parse(s[2]);
    int D = int.Parse(s[3]);

    if (B > C && D > A && C+D > A+B && C >= 0 && D >= 0 && A%2 == 0)
    {
      Console.WriteLine("Valores aceitos");
    }
    else
    Console.WriteLine("Valores nao aceitos");
    
  }
}
