using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class HamburgerBuilder : SanduicheBuilder
    {
        private Sanduiche s = new Hamburguer();

        public override void AbrePao()
        {
            System.Console.WriteLine("Abre o pão do hamburger");
        }

        public override void FechaPao()
        {
            System.Console.WriteLine("Fecha o pão do hamburger");
        }

        public override Sanduiche GetSanduiche()
        {
            System.Console.WriteLine("Hamburger está pronto");
            return s;
        }

        public override void InsereIngredientes()
        {
            System.Console.WriteLine("Insere queijo e carne");
        }
    }
}
