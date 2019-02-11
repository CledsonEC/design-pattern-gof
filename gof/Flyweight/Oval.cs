using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class Oval : Figura
    {
        private Boolean preenchido;
        public Oval(Boolean preenchido)
        {

            this.preenchido = preenchido;
        }
        public override void Desenha(string cor)
        {
            if(preenchido)
                Console.WriteLine("Figura Oval preenchido " + cor);
            else
                Console.WriteLine("Figura Oval não preenchido " + cor);
        }
    }
}
