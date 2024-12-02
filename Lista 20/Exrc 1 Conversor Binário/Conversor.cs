using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_1_Conversor_Binário
{
    class Conversor
    {
        private int num;
        private Stack <int> pilha = new Stack<int>();

        public void SetNum(int num) { this.num = num; }
        public string Binario()
        {
            string x = "";
            while (num > 0)
            {
                pilha.Push(num % 2);
                num /= 2;
            }
            while (pilha.Count > 0) x += pilha.Pop().ToString();
            return x;
        }
    }
}
