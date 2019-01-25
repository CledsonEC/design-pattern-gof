using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class EmpresaOnibus
    {
        public abstract PassagemOnibusUrbano EmitePassagemOnibusUrbano(String origem, String destino, DateTime dataHoraPartida);
        public abstract PassagemOnibusInterestadual EmitePassagemOnibusInterestadual(String origem, String destino, DateTime dataHoraPartida);
    }
}
