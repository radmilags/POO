using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_3_Conta_Bancaria
{
    class ContaBancaria
    {
        private string numero;
        private double saldo;
        public ContaBancaria(string n, double s)
        {
            numero = n; saldo = s;
        }
        public void Deposito(double d)
        {
            if (d < 0) throw new ArgumentOutOfRangeException("Valor inválido");
            else
            {
                saldo += d;
            }
        }
        public void Sacar(double d)
        {
            if (d < 0) throw new ArgumentOutOfRangeException("Valor inválido");
            else if (d > saldo) throw new InversaoSaldoException("Valor acima do permitido");
            else saldo -= d;
        }
        public double Saldo() { return saldo; }
    }
}
