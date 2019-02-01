using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class TomadaAmericana : Tomada<PlugAmericano>
    {
        public override string Conecta(PlugAmericano plug)
        {
            return plug.ObtemEletrecidade() + this.GetNomeRede();
        }

        public override string GetNomeRede()
        {
            return "tomada americana";
        }
    }
}
