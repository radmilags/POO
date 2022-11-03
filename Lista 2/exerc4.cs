using System;
class HelloWorld {
  static void Main() 
  {
    Console.WriteLine("Digite a base e a altura do retângulo");
    double b = double.Parse(Console.ReadLine());
    double h = double.Parse(Console.ReadLine());
    double area = b*h/2;
    double diagonal = Math.Sqrt(b*b+h*h);
    Console.WriteLine($"Área = {area:0.00} - Perímetro = {b+h+diagonal:0.00} - Diagonal = {diagonal:0.00}");
  }
}
