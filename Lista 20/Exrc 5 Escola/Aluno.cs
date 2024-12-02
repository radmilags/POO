using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_5_Escola
{
    class Aluno : IComparable
    {
        private string nome, matricula;
        public Aluno(string n, string m) { nome = n; matricula = m; }
    }
}
