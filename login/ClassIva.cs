using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    class ClassIva
    {
        double iva = 0.23 * 1;

        public double CalcularPrecoFinal(double preco_inicial)
        {
            double preco_final = 0;
            preco_final = preco_inicial + (preco_inicial * iva);
            return preco_final;
        }
    }
}
