using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class ConcreteEmpresaOnibus : EmpresaOnibus
    {
        public override PassagemOnibusInterestadual EmitePassagemOnibusInterestadual(string origem, string destino, DateTime dataHoraPartida)
        {
            return new ConcretePassagemOnibusInterestadual(origem, destino, dataHoraPartida);
        }

        public override PassagemOnibusUrbano EmitePassagemOnibusUrbano(string origem, string destino, DateTime dataHoraPartida)
        {
            return new ConcretePassagemOnibusUrbano(origem, destino, dataHoraPartida);
        }
    }
}
