using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_4_Construtora
{
    class Engenheiro : Funcionario
    {
        private string crea;
        public void SetCrea(string c) { crea = c; }
        public string GetCrea() { return crea; }
        public override string ToString()
        {
            return crea;
        }
    }
}