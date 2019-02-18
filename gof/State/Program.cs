using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Pato p = new Pato();
            p.SetComportamentoVoar(new NaoVoar());

            p.voar();
            p.Grasnar();
            Console.ReadKey();
        }
    }
}
