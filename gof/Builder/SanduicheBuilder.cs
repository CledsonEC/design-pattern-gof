using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public abstract class SanduicheBuilder
    {
        public abstract void AbrePao();
        public abstract void InsereIngredientes();
        public abstract void FechaPao();
        public abstract Sanduiche GetSanduiche();
    }
}
