using System;
class HelloWorld {
  static void Main() 
  {
    Console.WriteLine("Digite o intervalo de tempo no formato “HH:MM:SS”");
    string[] s = Console.ReadLine().Split(':');
    Console.WriteLine(s[0]); Console.WriteLine(s[1]); Console.WriteLine(s[2]);
    long seg = long.Parse(s[2]);
    seg += long.Parse(s[0])*3600;
    seg += long.Parse(s[1])*60;
    seg*=300000;
    Console.WriteLine($"A luz percorreu {seg} km nesse intervalo");
  }
}
