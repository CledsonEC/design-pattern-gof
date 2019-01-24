using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class EmpresaOnibusInterestadual : Empresa
    {
        public override Passagem EmitePassagem(string origem, string destino, DateTime dataHoraPartida)
        {
            return new PassagemOnibusInterestadual(origem, destino, dataHoraPartida);
        }
    }
}
