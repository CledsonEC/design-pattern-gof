using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Empresas de ônibus
            Empresa vicaoABC = new EmpresaOnibusUrbano();
            Empresa viacaoXYZInter = new EmpresaOnibusInterestadual();

            //Emite Passagens
            Passagem pUrbano = vicaoABC.EmitePassagem("SP", "BH", DateTime.Now);
            Passagem pInterestadual = viacaoXYZInter.EmitePassagem("BH", "PT", DateTime.Now.AddDays(5));

            //Exibe detalhe passagens
            pUrbano.ExibirDetalhes();
            pInterestadual.ExibirDetalhes();
            Console.ReadKey();
        }
    }
}
