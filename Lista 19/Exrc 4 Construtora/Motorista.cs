using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_4_Construtora
{
    class Motorista : Funcionario
    {
        private string cnh;
        public void SetCnh(string c) { }
        public string GetCnh() { return cnh; }
        public override string ToString()
        {
            return cnh;
        }
    }
}