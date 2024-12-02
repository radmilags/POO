using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_3_Sistema_Bancario
{
    class Poupança : ContaCorrente
    {
        public Poupança(string t, string n) : base(t, n) { }
        public void Render(double juros) { saldo *= juros; }
    }
}