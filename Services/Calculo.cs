using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abtrix.Services
{
    public class Calculo
    {
        public double CalcularJurosCompostos(double valorInicial, double valorAporte, double taxa, double periodo)
        {
            double valorFinal = valorInicial * Math.Pow(1 + taxa, periodo) + valorAporte * (Math.Pow(1 + taxa, periodo) - 1) / taxa;
            return valorFinal;
        }
        public double CalcularTotalAportado(double valorAporte, double periodo)
        {
            return valorAporte * periodo;
        }
    }
}
