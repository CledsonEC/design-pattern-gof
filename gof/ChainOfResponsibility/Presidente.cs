using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class Presidente : TomadorDeDecisao
    {
        public override void Aprova(Compra compra)
        {
            if (compra.GetValor() < 10000F)
            {
                Console.WriteLine("Compra aprovada pelo Presidente");
            }
            else
            {
                Console.WriteLine("compra não aprovada");
            }
        }
    }
}
