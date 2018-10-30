using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edipo_ContaPoupança
{
    class ContaPoupanca
    {
        static public int saldoPoupanca = poupador1 + poupador2;
        static public double taxaDeJurosAnual = 0.04;
        static public double AlterarTaxaDeJuros = 0.05;
        static public int poupador1 = 2000;
        static public int poupador2 = 3000;

        public double CalcularJurosMensal()

        {
            return saldoPoupanca * taxaDeJurosAnual / 12;

        }

        public double CalcularJurosAnual()
        {
            return saldoPoupanca * AlterarTaxaDeJuros / 12;

        }
    }
}
