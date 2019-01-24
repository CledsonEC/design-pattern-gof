using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class PassagemOnibusUrbano : Passagem
    {
        public PassagemOnibusUrbano(string origem, string destino, DateTime dataHoraPartida) 
            : base(origem, destino, dataHoraPartida)
        {

        }

        public override void ExibirDetalhes()
        {
            System.Console.WriteLine(String.Format("Passagem de ônibus urbano: {0} para {1}, Data Hora: {2}", this.Origem, this.Destino, this.DataHoraPartida));
        }
    }
}
