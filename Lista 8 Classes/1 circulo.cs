/******************************************************************************
1. Um Círculo
A classe deve ter um atributo raio para armazenar a dimensão da figura e métodos para calcular sua área e sua
circunferência.
Escrever um programa para testar a classe.

*******************************************************************************/
using System;
class Circulo{
    public double raio;
    public double Area(){return 3.14*raio*raio;}
    public double Circunferencia(){return 2*3.14*raio;}
}
class HelloWorld {
  static void Main() {
    Circulo c = new Circulo();
    c.raio = double.Parse(Console.ReadLine());
    Console.WriteLine($"Area = {c.Area()} Circunferencia = {c.Circunferencia()}");
  }
}
