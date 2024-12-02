using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_3_Conta_Bancaria
{
    class Cliente
    {
        private string nome, email, fone;
        private int k;
        ContaBancaria[] c = new ContaBancaria[50];
        public Cliente(string n, string e, string f)
        {
            nome = n; email = e; fone = f;
        }
        public void Inserir(ContaBancaria conta)
        {
            if (k < 50) c[k++] = conta;
        }
        public ContaBancaria[] Listar()
        {
            ContaBancaria[] r = new ContaBancaria[k];
            Array.Copy(c, r, k);
            return r;
        }
    }
}
