﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_6_Bingo
{
    class Bingo
    {
        private int numBolas;
        private int[] v;
        private int c;
        public void Iniciar(int numBolas)
        {
            // Número de bolas
            this.numBolas = numBolas;
            // Número de bolas inseridas no vetor
            int k = 0;
            // Vetor com as bolas sorteadas
            v = new int[numBolas];
            // Sorteia um número
            Random r = new Random();
            while (k < numBolas)
            {
                int n = r.Next(1, numBolas + 1);
                // Procura o número no vetor
                if (Array.IndexOf(v, n) == -1)
                {
                    v[k] = n; k++;
                }
            }
        }
        public string Proximo()
        {
            if (c < numBolas)
            {
                int x = v[c];
                c++;
                return x.ToString();
            }
            return "Fim de Jogo";
        }
    }
}
