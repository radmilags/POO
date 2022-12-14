/******************************************************************************

3. Uma Viagem
Escrever a classe Viagem de acordo com o diagrama UML apresentado abaixo. A classe deve ter atributos para
armazenar a distância em km e o tempo gasto em horas e minutos da viagem realizada. A classe deve possuir
método para calcular a velocidade média atingida na viagem em km/h de acordo com a distância e o tempo gasto,
além dos métodos de acesso para definir e recuperar os atributos.
Escrever um programa para testar a classe.

*******************************************************************************/
using System;
class Viagem{
    private double distancia;
    private double tempo;
    public void SetDistancia(double d){
        if(d > 0) distancia = d;
    }
    public void SetTempo(double t){
        if(t > 0) tempo = t;
    }
    public double GetDistancia(){
        return distancia;
    }
    public double GetTempo(){
        return tempo;
    }
    public double VelocidadeMedia(){
        return distancia/tempo;
    }
}
class HelloWorld {
  static void Main() 
  {
    Viagem v = new Viagem();
    v.SetDistancia(50);
    v.SetTempo(10);
    Console.WriteLine(v.VelocidadeMedia());
  }
}
