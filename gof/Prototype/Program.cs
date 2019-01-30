using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            //Carregar os diferentes tipos de notas musicais
            Partitura.CarregarNotas();

            //Compor a canção
            Partitura.GetNota("Do").desenha();
            Partitura.GetNota("Re").desenha();
            Partitura.GetNota("Mi").desenha();
            Partitura.GetNota("Fa").desenha();
            Partitura.GetNota("Fa").desenha();
            Partitura.GetNota("Fa").desenha();
            Partitura.GetNota("Do").desenha();
            Partitura.GetNota("Re").desenha();
            Partitura.GetNota("Do").desenha();
            Partitura.GetNota("Re").desenha();
            Partitura.GetNota("Re").desenha();
            Partitura.GetNota("Re").desenha();

            Console.ReadKey();

        }
    }
}
