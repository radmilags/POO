using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_6_Empresa
{
    class Empresa
    {
        private List<Cliente> clientes;
        public void Inserir(Cliente c) { clientes = c; }
        public void Excluir(Cliente c) { }
        public void Socios(Cliente x, Cliente y) { }
        public List<Cliente> ListarNome() { }
        public List<Cliente> ListarLimite() { }
        public List<Cliente> ListarNaoSocio() { }
    }
}
