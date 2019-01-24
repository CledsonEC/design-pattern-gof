using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class Passagem
    {
        public String Origem { get; set;}
        public String Destino { get; set; }
        public DateTime DataHoraPartida { get; set; }

        public Passagem(String origem, String destino, DateTime dataHoraPartida)
        {
            this.Origem = origem;
            this.Destino = destino;
            this.DataHoraPartida = dataHoraPartida;
        }

        public abstract void ExibirDetalhes();

    }
}
