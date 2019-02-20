using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class VicePresidente : TomadorDeDecisao
    {
        public override void Aprova(Compra compra)
        {
            if( compra.GetValor() < 30000F)
            {
                Console.WriteLine("Compra aprovada pelo Vice-Presidente");
            }
            else if(sucessor != null)
            {
                sucessor.Aprova(compra);
            }
        }
    }
}
