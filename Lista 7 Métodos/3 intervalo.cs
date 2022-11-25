using System;
class HelloWorld {
    public static void Intervalo(double x, out int a, out int b){
        a = (int) x;
        b = a+1;
    }
  static void Main() 
  {
    double x = 4.3;
    int m, n;
    
    Intervalo(x, out m, out n);
    
    Console.WriteLine($"{m} {n}");
  }
}
