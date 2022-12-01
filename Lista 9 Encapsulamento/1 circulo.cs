/******************************************************************************

1. Um Círculo
Escrever a classe Círculo de acordo com o diagrama UML apresentado abaixo. A classe deve ter um atributo raio
para armazenar a dimensão da figura e métodos para calcular sua área e sua circunferência, além dos métodos de
acesso para definir e recuperar o atributo raio.
Escrever um programa para testar a classe.

*******************************************************************************/
using System;
class Circulo{
    private double raio;
    public void SetRaio(double v){
        if(v > 0) raio = v;
        else Console.WriteLine("Raio inválido");
    }
    public double GetRaio(){
        return raio;
    }
    public double CalcArea(){
        return 3.14*raio*raio;
    }
    public double CalcCirc(){
        return 2*3.14*raio;
    }
}

class HelloWorld {
  static void Main() 
  {
    Circulo c = new Circulo();
    c.SetRaio(-5.5);
    Console.WriteLine(c.GetRaio());
    Console.WriteLine(c.CalcArea());
    Console.WriteLine(c.CalcCirc());
  }
}
