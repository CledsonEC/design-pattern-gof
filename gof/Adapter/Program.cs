using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Target
            TomadaBrasileira tomadaBras = new TomadaBrasileira();

            //Adaptado
            PlugAmericano plugWUA = new PlugAmericano();
            AdapterEUAtoBrasil tomadaModificada = new AdapterEUAtoBrasil();
            String s = tomadaModificada.Conecta(plugWUA);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
