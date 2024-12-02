using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_5_Escola
{
    class Turma :  IComparable
    {
        private string semestre, disciplina;
        private List<Aluno> alunos;
        public int NumAlunos;
        public Turma(string s, string d) { semestre = s; disciplina = d; }
        public void AdicionarAluno(Aluno a) { alunos = a; }
        public Aluno[] ListarAluno() { }
    }
}
