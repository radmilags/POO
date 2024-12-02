using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_3_Sistema_Bancario
{
    class ContaCorrente
    {
        private string titular, numeroConta;
        protected double saldo;
        public ContaCorrente(string t, string n)
        {
            if (t != "" && n != "") { titular = t; numeroConta = n; }
        }
        public void Depositar(double valor)
        {
            saldo += valor;
        }
        public bool Sacar(double valor)
        {
            if (valor > 0 && saldo >= 0) { saldo -= valor; return true; }
            return false;
        }
        public double RetornarSaldo() { return saldo; }
        public override string ToString()
        {
            return $"{titular} - {numeroConta} - {saldo}";
        }
    }
}