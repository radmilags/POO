using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_2_Retangulo
{
    class Retangulo
    {
        private double b, h;
        public Retangulo(double b, double h)
        {
            if (b > 0) this.b = b;
            else throw new ArgumentException("Valor inválido");
            if (h > 0) this.h = h;
            else throw new ArgumentException("Valor inválido");
        }
        public double AreaRet()
        {
            return b * h;
        }
    }
}
