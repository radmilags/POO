using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_2_Sequências
{
    class Fibonacci
    {
        private int primeiroElemento = 0;
        private int proximoElemento = 1, aux = 0;
        public int Iniciar()
        {
            return primeiroElemento;
        }
        public int Proximo()
        {
            aux = primeiroElemento;
            primeiroElemento = proximoElemento;
            proximoElemento += aux;
            return primeiroElemento;

        }
    }
}
