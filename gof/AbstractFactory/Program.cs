using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Empresas de ônibus
            EmpresaOnibus viacaoXYZ = new ConcreteEmpresaOnibus();

            //Emite passagens
            PassagemOnibusUrbano pUrbano = viacaoXYZ.EmitePassagemOnibusUrbano("S�o Paulo", "Campinas", DateTime.Now);

            PassagemOnibusInterestadual pInterestadual = viacaoXYZ.EmitePassagemOnibusInterestadual("S�o Paulo", "Rio de Janeiro", DateTime.Now);

            //Exibe detalhes da passagem
            pUrbano.ExibirDetalhes();

            pInterestadual.ExibirDetalhes();
        }
    }
}
