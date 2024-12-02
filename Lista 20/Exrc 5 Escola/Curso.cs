using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_5_Escola
{
    class Curso
    {
        private string descricao;
        private List<Turma> turmas;
        private int k;
        public Curso(string d) { descricao = d; }
        public void AdicionarTurma(Turma t) { k++; }
        public Turma[] ListarTurma() { }
    }
}
