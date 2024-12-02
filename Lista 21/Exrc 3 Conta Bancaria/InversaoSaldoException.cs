using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_3_Conta_Bancaria
{
    class InversaoSaldoException : ArgumentException
    {
        public InversaoSaldoException(string message) : base(message) { }
    }
}
