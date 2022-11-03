using System;
class HelloWorld {
  static void Main() 
  {
    Console.WriteLine("Digite a nota do primeiro bimestre da disciplina:");
    int n = int.Parse(Console.ReadLine());
    while(n < 0 || n > 100){
        Console.WriteLine("Digite a nota do primeiro bimestre da disciplina:");
        n = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("Digite a nota do segundo bimestre da disciplina:");
    int n1 = int.Parse(Console.ReadLine());
    while(n1 < 0 || n1 > 100){
        Console.WriteLine("Digite a nota do segundo bimestre da disciplina:");
        n1 = int.Parse(Console.ReadLine());
    }
    int media = (n1*3+n*2)/5;
    Console.WriteLine($"Média parcial = {media}");
  }
}
