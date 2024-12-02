using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_4_Jogo
{
    class Jogador :  IComparable
    {
        private string nome, email;
        private int PontuacaoMaxima;
        private DateTime data;
        public Jogador(string n, string e) { nome = n; email = e; }
        public void SetPontos(int p, DateTime d)
        {
            if (PontuacaoMaxima > 0) PontuacaoMaxima = p;
            else throw new ArgumentOutOfRangeException("Valor informado inválido");

            if (d < DateTime.Now) data = d;
            else throw new ArgumentOutOfRangeException("Data informada inválida");
        }
        public string GetEmail() { return email; }
        public int CompareTo(object obj)
        {
            Jogador j = obj as Jogador;

            if (this.PontuacaoMaxima > j.PontuacaoMaxima) return -1;
            if (this.PontuacaoMaxima < j.PontuacaoMaxima ) return 1;

            return this.data.CompareTo(j.data);

        }
        public override string ToString() { return $"{nome} - {email} - {PontuacaoMaxima} - {data}"; }
    }
}
