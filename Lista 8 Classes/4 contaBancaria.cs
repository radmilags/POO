/******************************************************************************

4. Uma Conta Bancária
A classe deve ter atributos para armazenar o nome do titular da conta, o número da conta e seu saldo e métodos
para realizar as operações de depósito e saque.
Escrever um programa para testar a classe.

*******************************************************************************/
using System;
class Conta{
    private string nome, numero;
    private double saldo;
    public Conta(string nome, string numero, double saldo){
        this.nome = nome; this.numero = numero; this.saldo = saldo;
    }
    public string Saque(double d){
        if(saldo - d < 0) return "Saldo Indisponível para saque";
        else saldo -= d;
        return "Saque efetuado com sucesso";
    }
    public string Deposito(double d){
        saldo += d;
        return "Deposito efetuado com sucesso";
    }
    public string Saldo(){
        return $"{saldo}";
    }
}
class HelloWorld {
  static void Main() 
  {
    string nome = Console.ReadLine();
    string numero = Console.ReadLine();
    double saldo = double.Parse(Console.ReadLine());
    Conta c = new Conta(nome, numero, saldo);
    Console.WriteLine(c.Saldo());
    Console.WriteLine(c.Deposito(0));
    Console.WriteLine(c.Saldo());
    Console.WriteLine(c.Saque(20));
    Console.WriteLine(c.Saldo());
  }
}
