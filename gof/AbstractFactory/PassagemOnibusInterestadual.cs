using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class PassagemOnibusInterestadual
    {
        public String Origem { get; set; }
        public String Destino { get; set; }
        public DateTime DataHoraPartida { get; set; }

        protected PassagemOnibusInterestadual(string origem, string destino, DateTime dataHoraPartida)
        {
            Origem = origem;
            Destino = destino;
            DataHoraPartida = dataHoraPartida;
        }

        public abstract void ExibirDetalhes();
    }
}
