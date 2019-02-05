using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class Decoracao : Arvore
    {
        private Arvore arvore;

        public Decoracao( Arvore arvore)
        {
            this.arvore = arvore;
        }

        public override void ShowEnfeites()
        {
            arvore.ShowEnfeites();
        }
    }
}
