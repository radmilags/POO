using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_5_Dicionario
{
    class Dicionario<k,v>
    {
        private List<k> chaves = new List<k>();
        private List<v> valores = new List<v>();
        public List<k> Chaves { get => chaves; }
        public int Count { get => valores.Count; } //Count retorna a quantidade de elementos de uma lista;
        public v this[k chave]
        {
            set
            {
                if (chaves.Contains(chave)) valores[chaves.IndexOf(chave)] = value; //O countains diz se certo elemento está dentro de uma lista;
                else
                {
                    chaves.Add(chave);
                    valores.Add(value);
                }
            }
            get
            {
                int p = chaves.IndexOf(chave);
                if (p == -1) throw new Invalid("Nenhum resultado encontrado");
                else return valores[p];
            }
        }
        public void Add(k chave, v valor)
        {
            if (chave == null || valor == null)
                throw new Argument("O valor fornecido é inválido");
            else if (chaves.IndexOf(chave) == -1 || valores.IndexOf(valor) == -1)
            { chaves.Add(chave); valores.Add(valor); }
            else throw new Invalid("O item já foi adicionado ao dicionário");
        }
        public void Clear() { chaves.Clear(); valores.Clear(); }
        public bool Contains(k chave)
        {
            bool x = false;

            return x;
        }
        public bool Remove(k chave)
        {
            bool x;
            if (chaves.IndexOf(chave) == -1) x = false;
            else
            {
                chaves.Remove(chave);
                x = true;
            }
            return x;
        }
    }
}
