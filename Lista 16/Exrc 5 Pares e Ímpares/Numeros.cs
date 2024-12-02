using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_5_Pares_e_Ímpares
{
    class Numeros
    {
        private int inicio;
        private int fim;
        public Numeros(int i, int f) {inicio = i; fim = f; } //método que deveria ser do tipo void?
        public int[] Calcular(bool p, bool i)
        {
            int[] n = new int[fim]; int x = 0;
            for (int j = inicio; j <= fim; j++)
            {
                if (p) { if (j % 2 == 0) { n[x] = j; x++; } }
                if (i) { if (j % 2 != 0) { n[x] = j; x++; } }
            }
            int[] z = new int[x];
            Array.Copy(n, z, x);
            return z;
        }
    }
}
