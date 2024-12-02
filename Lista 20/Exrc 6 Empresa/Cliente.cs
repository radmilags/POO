using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_6_Empresa
{
    class Cliente
    {
        private string nome, cpf;
        private decimal limite;
        private List<Cliente> socio;
        private decimal LimiteTotal;
        public Cliente(string n, string cpf, decimal l) { nome = n; this.cpf = cpf; limite = l; }
        public void Inserir(Cliente c) { }
        public void Excluir(Cliente c) { }
    }
}
