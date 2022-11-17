using System;
class Pais {
    private string nome;
    private int populacao;
    
    public Pais (string nome, int populacao) {
        this.SetNome(nome);
        this.SetPopulacao(populacao);
    }
    
    public void SetNome (string nome) {
        if (this.nome != " ") this.nome = nome;
    }
    
    public void SetPopulacao (int populacao) {
        if (this.populacao >= 0) this.populacao = populacao;
    }
    
    public string GetNome () {
        return this.nome;    
    }
    
    public int GetPopulacao () {
        return this.populacao;
    }
    
    public override string ToString () {
        return $"Nome = {this.nome}; Populacao = {this.populacao};";
    }
}
class HelloWorld {
  static void Main() 
  {
    int n = int.Parse(Console.ReadLine());
    Pais[] p = new Pais[n];
    
    for (int i = 0; i < n; i++) {
        Console.WriteLine($"Pais {i+1}");
        string nome = Console.ReadLine();
        int populacao = int.Parse(Console.ReadLine());
        p[i] = new Pais (nome, populacao);
    }
    
    int maiorP = p[0].GetPopulacao(); 
    string nomeP = p[0].GetNome();
    
    for (int i = 1; i<n; i++) {
        if(p[i].GetPopulacao() > maiorP){
          maiorP = p[i].GetPopulacao(); 
          nomeP = p[i].GetNome();
        }
    }
    
    Console.WriteLine($"Pais mais populoso = {nomeP}");
  }
}
