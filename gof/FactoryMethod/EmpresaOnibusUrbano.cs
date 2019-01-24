using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class EmpresaOnibusUrbano : Empresa
    {
        public override Passagem EmitePassagem(string origem, string destino, DateTime dataHoraPartida)
        {
            return new PassagemOnibusUrbano(origem, destino, dataHoraPartida);
        }
    }
}
