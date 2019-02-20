using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tomadores de decis�o
            TomadorDeDecisao presidente = new Presidente();
            TomadorDeDecisao vicepresidente = new VicePresidente();
            TomadorDeDecisao diretor = new Diretor();
            TomadorDeDecisao gerente = new Gerente();

            gerente.SetSucessor(diretor);
            diretor.SetSucessor(vicepresidente);
            vicepresidente.SetSucessor(presidente);

            Compra compra = new Compra(500F);
            gerente.Aprova(compra);

            Console.ReadKey();
        }
    }
}
