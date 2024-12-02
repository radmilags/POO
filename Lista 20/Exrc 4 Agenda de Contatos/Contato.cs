using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_4_Agenda_de_Contatos
{
    class Contato
    {
        private string nome, email, fone;
        public Contato(string n, string e, string f) { nome = n; email = e; fone = f; }
        public string GetNome() { return nome; }
        public string GetEmail() { return email; }
        public string GetFone() { return fone; }
    }
}
