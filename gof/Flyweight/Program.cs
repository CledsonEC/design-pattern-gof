using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura f = FiguraFactory.GetFigura("linha");
            f.Desenha("amarela");

            f = FiguraFactory.GetFigura("oval não preenchida");
            f.Desenha("vermelha");
            Console.ReadKey();
        }
    }
}
