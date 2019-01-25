using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class PassagemOnibusUrbano
    {
        public String Origem { get; set; }
        public String Destino { get; set; }
        public DateTime DataHoraPartida { get; set; }

        public PassagemOnibusUrbano(string orgiem, string destino, DateTime dataHoraPartida)
        {
            Origem = orgiem;
            Destino = destino;
            DataHoraPartida = dataHoraPartida;
        }

        public abstract void ExibirDetalhes();
    }
}
