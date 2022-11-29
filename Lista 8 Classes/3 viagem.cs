/******************************************************************************

3. Uma Viagem
A classe deve ter atributos para armazenar a distância em km e o tempo gasto em horas e minutos da viagem
realizada. A classe deve possuir método para calcular a velocidade média atingida na viagem em km/h de acordo
com a distância e o tempo gasto.
Escrever um programa para testar a classe.

*******************************************************************************/
using System;
class Viagem{
    private double h, m, d;
    public Viagem(string t, double d){
        string[] s = t.Split(':');
        this.d = d;
        this.h = double.Parse(s[0]);
        this.m = double.Parse(s[1]);
    }
    public double Vm(){
        this.h += m/60;
        return d/h;
    }
}
class HelloWorld {
  static void Main() {
    string s = Console.ReadLine();
    double d = double.Parse(Console.ReadLine());
    Viagem v = new Viagem(s, d);
    Console.WriteLine(v.Vm());
  }
}
