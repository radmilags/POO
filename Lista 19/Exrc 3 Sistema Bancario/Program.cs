using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_3_Sistema_Bancario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0.Finalizar");
            Console.WriteLine("1.Conta Poupança");
            Console.WriteLine("2.Conta Especial");
            int op = int.Parse(Console.ReadLine());
            while (op != 0)
            {
                int n;
                if (op == 1)
                {
                    Console.WriteLine("Cadastro: ");
                    Poupança p = new Poupança(Console.ReadLine(), Console.ReadLine());
                    Console.WriteLine("0.Finalizar");
                    Console.WriteLine("1.Juros");
                    Console.WriteLine("2.Deposito");
                    Console.WriteLine("3.Saque");
                    Console.WriteLine("4.Saldo");
                    Console.WriteLine("5.Dados");
                    n = int.Parse(Console.ReadLine());
                    while(n != 0)
                    {
                        switch (n)
                        {
                            case 1:
                                p.Render(double.Parse(Console.ReadLine()));
                                break;
                            case 2:
                                p.Depositar(double.Parse(Console.ReadLine()));
                                break;
                            case 3:
                                p.Sacar(double.Parse(Console.ReadLine()));
                                break;
                            case 4:
                                Console.WriteLine(p.RetornarSaldo());
                                break;
                            case 5:
                                Console.WriteLine(p.ToString());
                                break;
                        }
                        Console.WriteLine("0.Finalizar");
                        Console.WriteLine("1.Juros");
                        Console.WriteLine("2.Deposito");
                        Console.WriteLine("3.Saque");
                        Console.WriteLine("4.Saldo");
                        Console.WriteLine("5.Dados");
                        n = int.Parse(Console.ReadLine());
                    }
                }
                else if(op == 2)
                {
                    Console.WriteLine("Cadastro: ");
                    ContaEspecial c = new ContaEspecial(Console.ReadLine(), Console.ReadLine(), double.Parse(Console.ReadLine()));
                    n = int.Parse(Console.ReadLine());
                    while (n != 0)
                    {
                        Console.WriteLine("0.Finalizar");
                        Console.WriteLine("1.Deposito");
                        Console.WriteLine("2.Saque");
                        Console.WriteLine("3.Saldo");
                        Console.WriteLine("4.Dados");
                        switch (n)
                        {
                            case 1:
                                c.Depositar(double.Parse(Console.ReadLine()));
                                break;
                            case 2:
                                c.Sacar(double.Parse(Console.ReadLine()));
                                break;
                            case 3:
                                Console.WriteLine(c.RetornarSaldo());
                                break;
                            case 4:
                                Console.WriteLine(c.ToString());
                                break;
                        }
                        Console.WriteLine("0.Finalizar");
                        Console.WriteLine("1.Deposito");
                        Console.WriteLine("2.Saque");
                        Console.WriteLine("3.Saldo");
                        Console.WriteLine("4.Dados");
                        n = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("0.Finalizar");
                Console.WriteLine("1.Conta Poupança");
                Console.WriteLine("2.Conta Especial");
                op = int.Parse(Console.ReadLine());
            }
        }
    }
}
