using System;

class MainClass {
  public static void Main (string[] args) 
  {
    int A = int.Parse(Console.ReadLine());
    
    Console.WriteLine($"{A}");
    int cem = A / 100;
    A = A - cem * 100;
    int cin = A / 50;
    A = A - cin * 50;
    int vin = A / 20;
    A = A - vin * 20;
    int dez = A/10;
    A = A - dez * 10;
    int cinc = A/5;
    A = A - cinc * 5;
    int dois = A/2;
    A = A - dois * 2;
    int um = A/1;

    Console.WriteLine($"{cem} nota(s) de R$ 100,00");
    Console.WriteLine($"{cin} nota(s) de R$ 50,00");
    Console.WriteLine($"{vin} nota(s) de R$ 20,00");
    Console.WriteLine($"{dez} nota(s) de R$ 10,00");
    Console.WriteLine($"{cinc} nota(s) de R$ 5,00");
    Console.WriteLine($"{dois} nota(s) de R$ 2,00");
    Console.WriteLine($"{um} nota(s) de R$ 1,00");

  }
}
