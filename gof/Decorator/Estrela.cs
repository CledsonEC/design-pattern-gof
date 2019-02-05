using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Estrela : Decoracao
    {
        public Estrela(Arvore a) : base(a) { }

        public override void ShowEnfeites()
        {
            base.ShowEnfeites();
            Console.Write("Estrela, ");
        }
    }
}
