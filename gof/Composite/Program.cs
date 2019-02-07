using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria programadores (folhas)
            Programador pEstagiario = new Programador("José", 900);
            Programador pJunior = new Programador("Pedro", 2900);
            Programador pSenior = new Programador("Ricardo", 3900);

            //Gerentes
            Gerente g3 = new Gerente("João", 15000);
            Gerente g2 = new Gerente("Maria", 10000);
            Gerente g1 = new Gerente("Carlos", 5000);

            //Montar a estrutura em �rvore

            //Carlos superviosiona os programadores Jos� e Pedro
            g1.Add(pEstagiario);
            g1.Add(pJunior);

            //Maria superviosiona o programador Ricardo
            g2.Add(pSenior);

            //Jo�o � raiz da estrutura em �rvore
            g3.Add(g1);
            g3.Add(g2);

            g3.Print();

            Console.ReadKey();
        }
    }
}
