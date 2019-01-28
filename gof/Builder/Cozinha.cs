using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Cozinha
    {
        public void FazSanduiche(SanduicheBuilder builder)
        {
            builder.AbrePao();
            builder.InsereIngredientes();
            builder.FechaPao();
        }
    }
}
