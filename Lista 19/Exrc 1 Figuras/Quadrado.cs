using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_1_Figuras
{
    class Quadrado : Retangulo
    {
        public Quadrado(double I) : base(I, I) { } 
        public override string ToString()
        {
            return $"{base.CalcArea()} - {base.CalcDiagonal()} - {base.GetAltura()}";
        }
    }
}
