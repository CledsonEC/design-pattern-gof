using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class Gerente : TomadorDeDecisao
    {
        public override void Aprova(Compra compra)
        {
            if (compra.GetValor() < 1000F)
            {
                Console.WriteLine("Compra aprovada pelo Gerente");
            }
            else if (sucessor != null)
            {
                sucessor.Aprova(compra);
            }
        }
    }
}
