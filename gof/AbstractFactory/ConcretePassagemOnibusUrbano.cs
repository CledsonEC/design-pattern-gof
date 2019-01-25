using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class ConcretePassagemOnibusUrbano : PassagemOnibusUrbano
    {
        public ConcretePassagemOnibusUrbano(string orgiem, string destino, DateTime dataHoraPartida) 
            : base(orgiem, destino, dataHoraPartida)
        {
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine(String.Format("Passagem de ônibus urbano: {0} para {1}, Data Hora: {2}", Origem, Destino, DataHoraPartida));
        }
    }
}
