using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Digite seu nome completo:");
    string[] s = Console.ReadLine().Split();
    Console.WriteLine($"Bem vindo ao C#, {s[0]}");
  }
}
