using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class AdapterEUAtoBrasil : TomadaBrasileira
    {
        public String Conecta(PlugAmericano plug) {
            return plug.ObtemEletrecidade() + GetNomeRede();
        }
    }
}
