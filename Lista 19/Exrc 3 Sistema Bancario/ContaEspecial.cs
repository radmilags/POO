using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_3_Sistema_Bancario
{
    class ContaEspecial : ContaCorrente
    {
        private double limite;
        public ContaEspecial(string t, string n, double l) : base(t, n) { limite = l; }
        public bool Sacar(double valor) { if (valor > 0 && valor >= limite) { saldo -= valor; return true; } return false; }
    }
}