using System;

class MainClass 
{
  public static bool primo(long n)
  {
    long i; bool p = true;
    if(n != 2) for(i = 2; i*i <= n; ++i)
    if(n % i == 0) {p = false; break;}
  return p;
  }
  public static void Main (string[] args) 
  {
    int n = int.Parse(Console.ReadLine()); long a;
    for(int i = 1; i <= n; i++)
    {
      while(n!= 0)
      {
        n--;
        a = int.Parse(Console.ReadLine());
        if(primo(a)) Console.WriteLine("Prime");
        else Console.WriteLine("Not Prime");
      }
    }
  }
}
