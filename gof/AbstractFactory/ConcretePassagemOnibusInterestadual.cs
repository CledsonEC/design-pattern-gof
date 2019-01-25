using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class ConcretePassagemOnibusInterestadual : PassagemOnibusInterestadual
    {
        public ConcretePassagemOnibusInterestadual(string origem, string destino, DateTime dataHoraPartida) 
            : base(origem, destino, dataHoraPartida)
        {
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine(String.Format("Passagem de ônibus interestadual: {0} para {1}, Data Hora: {2}", Origem, Destino, DataHoraPartida));
        }
    }
}
