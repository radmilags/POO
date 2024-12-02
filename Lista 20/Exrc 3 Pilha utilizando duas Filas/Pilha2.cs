using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_3_Pilha_utilizando_duas_Filas
{
    class Pilha2<T>
    {
        private Queue<T> q1 = new Queue<T>();
        private Queue<T> q2 = new Queue<T>();
        public int Count() //retornar a maior pilha
        {
            if (q1.Count > 0) return q1.Count;
            return q2.Count;
        }
        public T Top()
        {
            while (Count() > 1) q2.Enqueue(q1.Dequeue());
            T f = q1.Peek();
            q1.Enqueue(q2.Dequeue());
            return f;
        }
        public T Pop()
        {
            while (Count() > 1) q2.Enqueue(q1.Dequeue());
            T f = q1.Peek();
            q1.Enqueue(q2.Dequeue());
            return f;
        }
        public void Push(T obj)
        {
            q1.Enqueue(obj);
        }
    }
}
