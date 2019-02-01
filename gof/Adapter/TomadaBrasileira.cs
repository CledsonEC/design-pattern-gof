using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class TomadaBrasileira : Tomada<PlugBrasileiro>
    {
        public override string Conecta(PlugBrasileiro plug)
        {
            return plug.ObtemEletrecidade() + GetNomeRede();
        }

        public override string GetNomeRede()
        {
            return "tomada brasileira";
        }
    }
}
