using System;
class Pais{
  private string nome;
  private int populacao;
  private double area;
  public Pais(string n, int p, double a){
    this.SetNome(n);
    this.SetPopulacao(p);
    this.SetArea(a);
  }
  public void SetNome(string nome){
    if(nome != "") this.nome = nome;
  }
  public void SetPopulacao(int populacao){
    if(populacao >= 0) this.populacao = populacao;
  }
  public void SetArea(double area){
    if(area > 0) this.area = area;
  }
  public string GetNome(){
    return this.nome;
  }
  public int GetPopulacao(){
    return this.populacao;
  }
  public double GetArea(){
    return this.area;
  }
  public double Densidade(){
    double ans = this.populacao/this.area;
    return ans;
  }
  public override string ToString(){
    return $"Nome = {this.nome} - Populacao = {this.populacao} - Area = {this.area}";
  }
}

class Program {
  public static void Main (string[] args) {
    int n = int.Parse(Console.ReadLine()); string nome; int populacao; double area;
    Pais[] p = new Pais[n];
    for(int i = 0; i < n; i++){ //ler paises
      nome = Console.ReadLine();
      populacao = int.Parse(Console.ReadLine());
      area = double.Parse(Console.ReadLine());
      p[i] = new Pais(nome, populacao, area);
    }

    //calcular a maior densidade
    int id = 0; double maior = p[0].Densidade();
    for(int i = 1; i < n; i++){
      if(p[i].Densidade() > maior){
        maior = p[i].Densidade(); id = i;
        Console.WriteLine(p[i].Densidade());
      }
    }
    Console.WriteLine(p[id].ToString());
  }
}
