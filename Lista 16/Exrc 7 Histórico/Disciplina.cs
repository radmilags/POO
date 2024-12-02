using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_7_Histórico
{
    class Disciplina
    {
        private string nome;
        private int media;
        private bool aprovado;
        private string semestre;
        public string GetNome() { return nome; }
        public string GetSemestre() { return semestre; }
        public double GetMedia() { return media; }
        public bool GetAprovado() { return aprovado; }
        public Disciplina(string nome, string semestre, int media, bool a)
        {
            this.nome = nome;
            this.semestre = semestre;
            this.media = media;
            aprovado = a;
        }
        public override string ToString()
        {
            string s = "Aprovado";
            if (!aprovado) s = "Reprovado";
            return nome + " - " + semestre + " - " + media.ToString() + " - " + s;
        }
    }
}
