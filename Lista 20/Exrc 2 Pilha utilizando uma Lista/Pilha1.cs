using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_2_Pilha_utilizando_uma_Lista
{
    class Pilha1<T>
    {
        private List<T> lista = new List<T>();
        public int Count() { return lista.Count; }
        public T Top()
        {
            T t;
            t = lista[Count() - 1];
            return t;
        }
        public T Pop()
        {
            T t;
            t = lista[Count() - 1];
            lista.RemoveAt(Count() - 1);
            return t;
        }
        public void Push(T obj) { lista.Insert(Count(), obj); }
    }
}
