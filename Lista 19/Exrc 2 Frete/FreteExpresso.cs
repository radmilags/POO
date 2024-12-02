using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_2
{
    class FreteExpresso : Frete
    {
        private decimal seguro;
        public FreteExpresso(double d, double p, decimal s) :
            base(d, p)
        { seguro = s; }
        public decimal CalcFrete()
        {
            return base.CalcFrete() * Convert.ToDecimal(0.01) * seguro;
        }
        public override string ToString()
        {
            return $"{base.ToString()} - {seguro}";
        }
    }
}