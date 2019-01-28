using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class FishBuilder : SanduicheBuilder
    {
        private Sanduiche s = new Fishburguer();

        public override void AbrePao()
        {
            System.Console.WriteLine("Abre o pão do fishburger");
        }

        public override void FechaPao()
        {
            System.Console.WriteLine("Fecha o pão do fishburger");
        }

        public override Sanduiche GetSanduiche()
        {
            System.Console.WriteLine("Fishburger está pronto");
            return s;
        }

        public override void InsereIngredientes()
        {
            System.Console.WriteLine("Insere file de peixe");
        }
    }
}
