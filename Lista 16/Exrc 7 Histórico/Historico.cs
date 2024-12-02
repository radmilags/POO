using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_7_Histórico
{
    class Historico
    {
        //Aqui temos um código que eu n sei como chegou nisso, mas que preciso descobrir pois quero terminar info web
        private string aluno;
        private Disciplina[] discs = new Disciplina[10];
        private int k;
        public Historico(string aluno)
        {
            this.aluno = aluno;
        }
        public void Inserir(Disciplina d)
        {
            if (k < 10) discs[k++] = d;
        }
        public Disciplina[] Listar()
        {
            Disciplina[] novo = new Disciplina[k];
            Array.Copy(discs, novo, k);
            return novo;
        }
        public double IRA()
        {
            if (k == 0) return 0;
            double x = 0;
            foreach (Disciplina d in discs)
                if (d != null) x = x + d.GetMedia();
            return x / k;
        }
    }
}
