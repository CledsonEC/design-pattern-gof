using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class Linha : Figura
    {
        public Linha()
        {
        }

        public override void Desenha(string cor)
        {
            Console.WriteLine("Figura linha " + cor);
        }
    }
}
