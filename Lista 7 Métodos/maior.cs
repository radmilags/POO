using System;
class HelloWorld {
    public static double maior(int x, int y){
        if(x > y) return x;
        return y;
    }
  static void Main() 
  {
    int n = int.Parse(Console.ReadLine());
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine(maior(n,m));
  }
}
