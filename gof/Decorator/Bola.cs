using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Bola : Decoracao
    {
        public Bola(Arvore a) : base(a)
        {
        }
        public override void ShowEnfeites()
        {
            base.ShowEnfeites();
            Console.Write("Bola, ");
        }
    }
}
