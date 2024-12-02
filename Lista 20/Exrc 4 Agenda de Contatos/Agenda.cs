using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_4_Agenda_de_Contatos
{
    class Agenda
    {
        private List<Contato> cs;
        Contato[] cont = new Contato[50];
        public void Inserir(Contato c)
        {
            cs.Add(c);
        }
        public List<Contato> Listar()
        {
            foreach (List<Contato> c in cs) return c; 
        }
        public List<Contato> Pesquisar(string inicio) { return Array.IndexOf(cs, inicio); }
        public void Abrir() { }
        public void Salvar() { }
    }
}
