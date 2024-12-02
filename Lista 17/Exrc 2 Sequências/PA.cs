using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_2_Sequências
{
    class PA
    {
        private int primeiroElemento;
        private int razao;
        public PA(int razao)
        {
            this.razao = razao;
        }
        public int Iniciar()
        {
            primeiroElemento = 0;
            return primeiroElemento;
        }
        public int Proximo()
        {
            primeiroElemento += razao;
            return primeiroElemento;
        }
    }
}
