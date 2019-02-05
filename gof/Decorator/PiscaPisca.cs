using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class PiscaPisca : Decoracao
    {
        public PiscaPisca(Arvore a) : base(a)
        {

        }

        public override void ShowEnfeites()
        {
            base.ShowEnfeites();
            Console.Write("Pisca-pisca, ");
        }
    }
}
