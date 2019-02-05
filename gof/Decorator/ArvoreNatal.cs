using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    //Concrete component
    public class ArvoreNatal : Arvore
    {
        public override void ShowEnfeites()
        {
            Console.Write("Árvore de natal, ");
        }
    }
}
