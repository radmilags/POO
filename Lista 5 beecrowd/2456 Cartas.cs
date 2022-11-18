using System;

class MainClass {
  public static void Main (string[] args) 
  {
    string[] s = Console.ReadLine().Split(' ');
    int a = int.Parse(s[0]);
    int b = int.Parse(s[1]);
    int c = int.Parse(s[2]);
    int d = int.Parse(s[3]);
    int e = int.Parse(s[4]);

    if(a < b && b < c && c < d && d < e) Console.WriteLine ("C");
    else if (a > b && b > c && c > d && d > e) Console.WriteLine ("D");
    else Console.WriteLine ("N");
  }
}
