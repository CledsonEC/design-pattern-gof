using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class Diretor : TomadorDeDecisao
    {
        public override void Aprova(Compra compra)
        {
            if (compra.GetValor() < 10000F)
            {
                Console.WriteLine("Compra aprovada pelo Diretor.");
            }
            else if (sucessor != null)
            {
                sucessor.Aprova(compra);
            }
        }
    }
}
