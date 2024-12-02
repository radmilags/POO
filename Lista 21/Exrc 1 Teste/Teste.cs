using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_1_Teste
{
    class Teste : ITeste
    {
        public int Metodo1(int valor)
        {
            if (valor >= 0) return valor;
            else throw new Erro();
        }
    }
}
