using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_2
{
    class Frete
    {
        private double distancia, peso;
        public Frete(double d, double p)
        {
            if (d > 0 && p > 0) { distancia = d; peso = p; }
        }
        public double GetDistancia() { return distancia; }
        public double GetPeso() { return peso; }
        public decimal CalcFrete()
        {
            return Convert.ToDecimal(0.01) * Convert.ToDecimal(distancia) * Convert.ToDecimal(peso);
        }
        public override string ToString()
        {
            return $"{distancia} - {peso}";
        }
    }
}