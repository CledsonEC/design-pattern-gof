using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class Empresa
    {
        public abstract Passagem EmitePassagem(String origem, String destino, DateTime dataHoraPartida);
    }
}
