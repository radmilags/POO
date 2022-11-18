using System;

class MainClass {
  public static void Main (string[] args) 
  {
    double pi = 3.14159;
    double T,CIR,TRA,Q,R;
    string[] p = Console.ReadLine().Split(' ');
    double A = double.Parse(p[0]);
    double B = double.Parse(p[1]);
    double C = double.Parse(p[2]);

    T = A*C/2;
    CIR = pi*(C*C);
    TRA = (A+B)*C/2;
    Q = B*B;
    R = A*B;

    Console.WriteLine("TRIANGULO: {0:0.000}", T);
    Console.WriteLine("CIRCULO: {0:0.000}", CIR);
    Console.WriteLine("TRAPEZIO: {0:0.000}", TRA);
    Console.WriteLine("QUADRADO: {0:0.000}", Q);
    Console.WriteLine("RETANGULO: {0:0.000}", R);
  }
}
