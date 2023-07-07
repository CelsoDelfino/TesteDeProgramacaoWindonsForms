using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefazendoTesteDeProgramacao.Domain.Model
{
    public class Linha
    {
        public double ColunaAB { get; set; }

        public double CalculaDezPorCento()
        {
            return ColunaAB += ColunaAB * 0.1;
        }
    }
}
